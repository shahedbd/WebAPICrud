﻿namespace WebAPICrud.Model
{
    public class BaseEntity
    {
        public Int64 Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
