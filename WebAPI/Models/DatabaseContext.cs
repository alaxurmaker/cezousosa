using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using DBModels;

namespace WebAPI.Models
{

    //public class DatabaseContext : DbContext
    //{
    //    public DatabaseContext()
    //        : base("name=DatabaseContext")
    //    {
    //    }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        throw new UnintentionalCodeFirstException();
    //    }

    //    public virtual DbSet<User> Users { get; set; }
    //    public virtual DbSet<Teacher> Teachers { get; set; }
    //    public virtual DbSet<Subject> Subjects { get; set; }
    //    public virtual DbSet<StudentParent> StudentParents { get; set; }
    //    public virtual DbSet<StudentHistory> StudentHistories { get; set; }
    //   // public virtual DbSet<StudentGroup> StudentGroups { get; set; }
    //    public virtual DbSet<StudentGrade> StudentGrades { get; set; }
    //   // public virtual DbSet<StudentClassroom> StudentClassrooms { get; set; }
    //    public virtual DbSet<Student> Students { get; set; }
    //    public virtual DbSet<Season> Seasons { get; set; }
    //    public virtual DbSet<Room> Rooms { get; set; }
    //    public virtual DbSet<Parent> Parents { get; set; }
    //   // public virtual DbSet<GroupTimetable> GroupTimetables { get; set; }
    //    public virtual DbSet<Group> Groups { get; set; }
    //    public virtual DbSet<GradeRating> GradeRatings { get; set; }
    //    public virtual DbSet<FinalGrade> FinalGrades { get; set; }
    //    public virtual DbSet<Educator> Educators { get; set; }
    //   // public virtual DbSet<ClassroomTimetable> ClassroomTimetables { get; set; }
    //   // public virtual DbSet<Classroom> Classrooms { get; set; }
    //    public virtual DbSet<Address> Addresses { get; set; }
    //}
}