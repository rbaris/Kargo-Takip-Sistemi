//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kargo_Takip
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kurye
    {
        public int Kurye_id { get; set; }
        public int Kurye_sube_id { get; set; }
        public int Kurye_sifre { get; set; }
        public string Kurye_ad { get; set; }
        public string Kurye_soyad { get; set; }
        public string Kurye_tc_no { get; set; }
        public string Kurye_plaka { get; set; }
    
        public virtual Sube Sube { get; set; }
    }
}