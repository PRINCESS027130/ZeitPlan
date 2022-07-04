
    using System;
    using System.Collections.Generic;
   
    public partial class TBL_TIMETABLE
    {
      
        public int TIMETABLE_ID { get; set; }

        public int TEACHER_FID { get; set; }

        public int CLASS_FID { get; set; }

        public int SLOT_FID { get; set; }

        public int ROOM_FID { get; set; }

        public int COURSE_ASSIGN_FID { get; set; }

        public virtual TBL_CLASS TBL_CLASS { get; set; }

        public virtual TBL_COURSE_ASSIGN TBL_COURSE_ASSIGN { get; set; }

        public virtual TBL_ROOM TBL_ROOM { get; set; }

        public virtual TBL_SLOT TBL_SLOT { get; set; }

        public virtual TBL_TEACHER TBL_TEACHER { get; set; }
    }

