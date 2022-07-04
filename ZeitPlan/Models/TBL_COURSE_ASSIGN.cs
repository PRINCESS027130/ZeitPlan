
    using System;
    using System.Collections.Generic;
   

    public partial class TBL_COURSE_ASSIGN
    {
      
        public int COURSE_ASSIGN_ID { get; set; }

        public int COURSE_FID { get; set; }

        public int DEGREE_FID { get; set; }

        public virtual TBL_COURSE TBL_COURSE { get; set; }

        public virtual TBL_DEGREE TBL_DEGREE { get; set; }

        
        public virtual int TBL_TIMETABLEFID { get; set; }
    }

