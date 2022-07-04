
    using System;
    using System.Collections.Generic;
    

    public partial class TBL_DEGREE
    {
        public int DEGREE_ID { get; set; }

        public string DEGREE_NAME { get; set; }

        public int DEPARTMENT_FID { get; set; }

       
        public virtual int TBL_CLASSFID { get; set; }

        
        public virtual ICollection<TBL_COURSE> TBL_COURSE { get; set; }

        
        public virtual int TBL_COURSE_ASSIGNFID { get; set; }

        public virtual TBL_DEPARTMENT TBL_DEPARTMENT { get; set; }
    }

