
    using System;
    using System.Collections.Generic;
    

    public partial class TBL_COURSE
    {
        
       
        public int COURSE_ID { get; set; }

        public string COURSE_NAME { get; set; }

        public string CREDIT_HOURS { get; set; }

        public int DEGREE_FID { get; set; }

        
        public virtual int TBL_COURSE_ASSIGNFID { get; set; }

        public virtual TBL_DEGREE TBL_DEGREE { get; set; }
    }

