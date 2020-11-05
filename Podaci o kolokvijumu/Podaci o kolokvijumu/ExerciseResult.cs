using System;
using System.Collections.Generic;
using System.Text;

namespace Podaci_o_kolokvijumu
{
    class ExerciseResult
    {
        public ExerciseResult(int id, string studentName, string studentIndex, int studentPoints)
        {
            this.id = id;
            StudentName = studentName;
            StudentIndex = studentIndex;
            StudentPoints = studentPoints;
        }

        public int id { get; set; }
        public string StudentName { get; set; }
        public string StudentIndex { get; set; }
        public int StudentPoints { get; set; }
    }
}
