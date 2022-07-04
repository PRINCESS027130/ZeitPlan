
    using System;
    using System.Collections.Generic;
    

    public partial class TBL_CLASS
    {
        
        
        public int CLASS_ID { get; set; }

        public string SESSION { get; set; }

        public string SECTION { get; set; }

        public string SHIFT { get; set; }

        public int DEGREE_FID { get; set; }

        public virtual TBL_DEGREE TBL_DEGREE{ get; set; }

        
        public virtual int TBL_STUDENTFID { get; set; }

        
        public virtual int TBL_TIMETABLEFID { get; set; }
    }
