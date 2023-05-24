namespace LibraryAPI;
public class Reservation{
    public int Id{get;set;}
    public int userId{get;set;}
    public int bookId {get;set;}
    public DateOnly reservationDate{get;set;}
}