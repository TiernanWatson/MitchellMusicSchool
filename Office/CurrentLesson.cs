using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetabling.Objects;

namespace Timetabling
{
    public partial class CurrentLesson : UI.BaseForm
    {
        Lesson _lesson;
        
        public CurrentLesson()
        {
            InitializeComponent();
        }

        public CurrentLesson(Lesson lesson)
        {
            InitializeComponent();
            _lesson = lesson;
            if (_lesson.Id != 0)
            {

            }
        }

        // Functionality

        private void B_Submit_Click(object sender, EventArgs e)
        {
            // Updates the lesson object
            _lesson.Comments = RTB_Today.Text;
            _lesson.Attended = CB_Attended.Checked;
            DBAccess.LessonAccessLayer LAL = new DBAccess.LessonAccessLayer(Core.Session.Database);
            LAL.TutorUpdateLesson(_lesson); // Updates lesson in DB
        }
    }
}
