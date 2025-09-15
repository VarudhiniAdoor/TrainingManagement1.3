namespace Tms.Api.Models;

public class Enrollment
{
    public int EnrollmentId { get; set; }
    public int UserId { get; set; }
    public int BatchId { get; set; }
    public string? Status { get; set; }          
    public int? ManagerId { get; set; }
    public string? RejectReason { get; set; } // optional reason


    public DateTime? RequestedOn { get; set; }
   
    // Navigation
    public User User { get; set; } = null!;
    public User? Manager { get; set; }
    public Batch Batch { get; set; } = null!;
}
