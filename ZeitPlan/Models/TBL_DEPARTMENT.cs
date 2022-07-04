
    using System;
    using System.Collections.Generic;
   

    public partial class TBL_DEPARTMENT
    {
        
        public int DEPARTMENT_ID { get; set; }

        public string DEPARTMENT_NAME { get; set; }

        
        public virtual int TBL_DEGREEFID { get; set; }

        
        public virtual int TBL_ROOMFID { get; set; }

        
        public virtual int TBL_TEACHERFID { get; set; }
    }
}
