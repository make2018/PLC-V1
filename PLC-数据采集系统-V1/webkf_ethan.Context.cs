﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PLC_数据采集系统_V1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class webkf_ethan_Entities : DbContext
    {
        public webkf_ethan_Entities()
            : base("name=webkf_ethan_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BODYINFOL200> BODYINFOL200 { get; set; }
    
        public virtual int PRO_WX_FAULT_INSERT(string fAULT_DATE, string fAULT_AREA, string fAULT_DEVICE, Nullable<decimal> fAULT_TIME, string fAULT_TYPE, string fAULT_INFO, string fAULT_NAME)
        {
            var fAULT_DATEParameter = fAULT_DATE != null ?
                new ObjectParameter("FAULT_DATE", fAULT_DATE) :
                new ObjectParameter("FAULT_DATE", typeof(string));
    
            var fAULT_AREAParameter = fAULT_AREA != null ?
                new ObjectParameter("FAULT_AREA", fAULT_AREA) :
                new ObjectParameter("FAULT_AREA", typeof(string));
    
            var fAULT_DEVICEParameter = fAULT_DEVICE != null ?
                new ObjectParameter("FAULT_DEVICE", fAULT_DEVICE) :
                new ObjectParameter("FAULT_DEVICE", typeof(string));
    
            var fAULT_TIMEParameter = fAULT_TIME.HasValue ?
                new ObjectParameter("FAULT_TIME", fAULT_TIME) :
                new ObjectParameter("FAULT_TIME", typeof(decimal));
    
            var fAULT_TYPEParameter = fAULT_TYPE != null ?
                new ObjectParameter("FAULT_TYPE", fAULT_TYPE) :
                new ObjectParameter("FAULT_TYPE", typeof(string));
    
            var fAULT_INFOParameter = fAULT_INFO != null ?
                new ObjectParameter("FAULT_INFO", fAULT_INFO) :
                new ObjectParameter("FAULT_INFO", typeof(string));
    
            var fAULT_NAMEParameter = fAULT_NAME != null ?
                new ObjectParameter("FAULT_NAME", fAULT_NAME) :
                new ObjectParameter("FAULT_NAME", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PRO_WX_FAULT_INSERT", fAULT_DATEParameter, fAULT_AREAParameter, fAULT_DEVICEParameter, fAULT_TIMEParameter, fAULT_TYPEParameter, fAULT_INFOParameter, fAULT_NAMEParameter);
        }
    }
}
