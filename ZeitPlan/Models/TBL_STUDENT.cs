
    using System;
    using System.Collections.Generic;
    

    public partial class TBL_STUDENT
    {
       
        public int STUDENT_ID { get; set; }

        public string STUDENT_NAME { get; set; }

        public string STUDENT_EMAIL { get; set; }

        public string STUDENT_PASSWORD { get; set; }

        public int CLASS_FID { get; set; }

        public virtual TBL_CLASS TBL_CLASS { get; set; }
    }
