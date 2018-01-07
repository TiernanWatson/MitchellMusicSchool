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
using Timetabling.Objects;
using Timetabling.DBAccess;

namespace Timetabling
{
    public partial class F_TutorHome : UI.BaseForm
    {
        List<Lesson> _todaysLessons;
        Lesson _lesson;
        Tutor _tutor;
        
        public F_TutorHome()
        {
            InitializeComponent();
            _tutor = Session.CurUser;
            LessonAccessLayer LAL = new LessonAccessLayer(Session.Database);
            _todaysLessons = LAL.GetLessonsByTutorToday(_tutor);
            PopulateListBox();
        }

        // Functionality

        private void PopulateListBox()
        {
            foreach(Lesson l in _todaysLessons)
                LB_Lessons.Items.Add("Period: " + l.Block.Period.Id + " " + l.Block.Student.Forename + " " + l.Block.Student.Surname);
        }

        private void B_View_Click(object sender, EventArgs e)
        {
            _lesson = _todaysLessons[LB_Lessons.SelectedIndex];
        }

        private void B_Submit_Click(object sender, EventArgs e)
        {
            // Updates the lesson object
            _lesson.Comments = RTB_TodaysComments.Text;
            _lesson.Attended = CB_Attended.Checked;
            DBAccess.LessonAccessLayer LAL = new DBAccess.LessonAccessLayer(Core.Session.Database);
            LAL.TutorUpdateLesson(_lesson); // Updates lesson in DB
        }
    }
}
