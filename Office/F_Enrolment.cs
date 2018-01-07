using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetabling.Core;
using Timetabling.DBAccess;
using Timetabling.Objects;

namespace Timetabling
{
    public partial class F_Enrolment : UI.BaseForm
    {
        /* THE FILTERING PROCESS IS NUMERICALLY LABELLED IN THIS CLASS */

        Student _student;
        DayOfWeek _day;
        // Lists declared here to cut down on SQL
        List<Instrument> _instruments;
        List<Term> _terms;
        List<DayOfWeek> _days;
        List<Period> _periods;
        List<Tutor> _tutors;
        List<Room> _rooms;

        public F_Enrolment(Student student)
        {
            InitializeComponent();
            B_Enrol.Enabled = false;
            _student = student;
            FillLists();
            PopulateForm();
        }

        private void FillLists()
        {
            InstrumentAccessLayer IAL = new InstrumentAccessLayer(Session.Database);
            _instruments = IAL.GetAllInstruments();
            TermAccessLayer TAL = new TermAccessLayer(Session.Database);
            _terms = TAL.GetAllTerms();
            DayAccessLayer DAL = new DayAccessLayer(Session.Database);
            _days = DAL.GetAllDays();
            PeriodAccessLayer PAL = new PeriodAccessLayer(Session.Database);
            _periods = PAL.GetAllPeriods();
            TutorAccessLayer TuAL = new TutorAccessLayer(Session.Database);
            _tutors = TuAL.GetAllTutors();
            RoomAccessLayer RAL = new RoomAccessLayer(Session.Database);
            _rooms = RAL.GetAllRooms();
        }

        private void PopulateForm()
        {
            L_StuDetail.Text = _student.Id + " " + _student.Forename + " " + _student.Surname; // Updates student details label
            // Instruments
            foreach (Instrument i in _instruments) { CB_Instrument.Items.Add(i.Name); }
            // Terms
            foreach (Term t in _terms) { LB_Terms.Items.Add(t.Id); }
            // Days
            foreach (DayOfWeek d in _days) { LB_Day.Items.Add(d.ToString()); }
        }

        //
        // Functionality
        //

        private void B_Enrol_Click(object sender, EventArgs e)
        {
            BlockAccessLayer BAL = new BlockAccessLayer(Session.Database);
            BAL.CreateBlock(_student.Id, _instruments[CB_Instrument.SelectedIndex], _terms[LB_Terms.SelectedIndex], _rooms[CB_Rooms.SelectedIndex], _periods[CB_AvailTimes.SelectedIndex], _tutors[CB_AvailTutors.SelectedIndex], _days[LB_Day.SelectedIndex]);
            MessageBox.Show("Student enrolment successful!");
            this.Close();
        }

        // #1 Methods updates DAYS listbox with available days
        private void LB_Terms_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*LB_Day.Items.Clear();
            DayAccessLayer DAL = new DayAccessLayer(Session.Database);
            _days = DAL.GetAvailableDays(_instruments[CB_Instrument.SelectedIndex], _terms[LB_Terms.SelectedIndex]);
            foreach (DayOfWeek d in _days)
                LB_Day.Items.Add(d.ToString());*/
        }

        // #2a Method updates PERIODS drop-down with available periods
        private void LB_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_AvailTimes.Items.Clear();
            _day = _days[LB_Day.SelectedIndex];
            PeriodAccessLayer PAL = new PeriodAccessLayer(Session.Database);
            _periods = PAL.GetFreePeriods(_instruments[CB_Instrument.SelectedIndex], _terms[LB_Terms.SelectedIndex], _day);
            foreach (Period p in _periods)
                CB_AvailTimes.Items.Add(p.Id);
        }

        // #2b occurs if picking a custom date
        private void DTP_StartDate_ValueChanged(object sender, EventArgs e)
        {
            CB_AvailTimes.Items.Clear();
            if (DTP_StartDate.Value < _terms[LB_Terms.SelectedIndex].StartDate || DTP_StartDate.Value > _terms[LB_Terms.SelectedIndex].EndDate)
            {
                MessageBox.Show("The selected date is not within the selected term.");
            }
            else
            {
                _day = DTP_StartDate.Value.DayOfWeek;
                CB_AvailTimes.Items.Clear();
                PeriodAccessLayer PAL = new PeriodAccessLayer(Session.Database);
                _periods = PAL.GetFreePeriods(_instruments[CB_Instrument.SelectedIndex], _terms[LB_Terms.SelectedIndex], _day);
                foreach (Period p in _periods)
                    CB_AvailTimes.Items.Add(p.Id);
            }
        }

        // #3 Method updates TUTOR drop-down with available tutors
        private void CB_AvailTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_AvailTutors.Items.Clear();
            TutorAccessLayer TAL = new TutorAccessLayer(Session.Database);
            _tutors = TAL.GetAvailableTutorsInstrument(_instruments[CB_Instrument.SelectedIndex], _periods[CB_AvailTimes.SelectedIndex], _terms[LB_Terms.SelectedIndex], _day);
            foreach (Tutor t in _tutors) 
                CB_AvailTutors.Items.Add(t.Forename + " " + t.Surname + " - " + TAL.CalculateTutorEfficiency(t, _terms[LB_Terms.SelectedIndex]) + "% booked");
        }

        // #4 Gets available rooms
        private void CB_AvailTutors_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomAccessLayer RAL = new RoomAccessLayer(Session.Database);
            _rooms = RAL.GetAvailableRooms(_terms[LB_Terms.SelectedIndex], _day, _periods[CB_AvailTimes.SelectedIndex]);
            foreach (Room r in _rooms)
                CB_Rooms.Items.Add(r.Id + " on floor " + r.Floor);
        }

        // #5
        private void CB_Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            B_Enrol.Enabled = true;
        }

        // Clears form for another go
        private void B_Reset_Click(object sender, EventArgs e)
        {
            LB_Day.Items.Clear();
            CB_AvailTimes.Items.Clear();
            CB_AvailTutors.Items.Clear();
            B_Enrol.Enabled = false;
            FillLists();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(Pens.LightGray, P_StudentInfo.Location.X, P_StudentInfo.Height + P_StudentInfo.Location.Y, P_StudentInfo.Width + P_StudentInfo.Location.X, P_StudentInfo.Height + P_StudentInfo.Location.Y);
        }

        private void L_StuDetail_Click(object sender, EventArgs e)
        {

        }

        private void L_EnrollingStu_Click(object sender, EventArgs e)
        {

        }
    }
}
