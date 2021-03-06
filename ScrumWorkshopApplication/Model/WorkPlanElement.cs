﻿using System;
using System.Data.Linq.Mapping;

namespace ScrumWorkshopApplication.Model
{
  [Table(Name = "WorkPlan")]
  public class WorkPlanElement
  {
    [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ID { get; set; }
    [Column]
    public Worker Worker { get; set; }
    [Column]
    public DayOfWeek DayOfWeek { get; set; }
    [Column]
    public TimeSpan StartTime { get; set; }
    [Column]
    public TimeSpan EndTime { get; set; }
    [Column]
    public Room Room { get; set; }
    [Column]
    public Class Class { get; set; }
  }
}
