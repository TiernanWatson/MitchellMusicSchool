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
    public partial class TutorHome : UI.BaseForm
    {
        List<Lesson> _todaysLessons;
        Tutor _tutor;
        
        public TutorHome()
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
            Lesson selectedLesson = _todaysLessons[LB_Lessons.SelectedIndex];
            CurrentLesson lessonWindow = new CurrentLesson(selectedLesson);
            lessonWindow.Show();
        }
    }
}
