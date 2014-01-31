//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODM_1_1_1EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Site
    {
        public Site()
        {
            this.DataValues = new HashSet<DataValue>();
        }
    
        public int SiteID { get; set; }
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int LatLongDatumID { get; set; }
        public Nullable<double> Elevation_m { get; set; }
        public string VerticalDatum { get; set; }
        public Nullable<double> LocalX { get; set; }
        public Nullable<double> LocalY { get; set; }
        public Nullable<int> LocalProjectionID { get; set; }
        public Nullable<double> PosAccuracy_m { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string Comments { get; set; }
        public string SiteType { get; set; }
    
        public virtual ICollection<DataValue> DataValues { get; set; }
        public virtual SiteTypeCV SiteTypeCV { get; set; }
        public virtual SpatialReference SpatialReference { get; set; }
        public virtual SpatialReference SpatialReference1 { get; set; }
        public virtual VerticalDatumCV VerticalDatumCV { get; set; }
    }
}
