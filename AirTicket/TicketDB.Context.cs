﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirTicket
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirTicketEntities : DbContext
    {
        public AirTicketEntities()
            : base("name=AirTicketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<From> Froms { get; set; }
        public virtual DbSet<To> Toes { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<TicketType> TicketTypes { get; set; }
    }
}
