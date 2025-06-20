namespace apbdKolos1Poprawa.Services;

public class DBService : IDBService
{
    private readonly string _connectionString;

    public DBService(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Default");
    }
    // public async Task<BookingDTO> GetBookingDetailsAsync(int BookingId)
    // {
    //    BookingDTO? dto = null;

        string cmd = @"Select *  Employee.first_name, Employee.last_name,Employee.employee_number From Booking
Join Guest on Booking.guest_id = guest_id
Join Employee on Booking.employee_id = employee_id
Join Booking_Attraction on Booking.booking_id = booking_id
Join Attraction on Booking_Attraction.attraction_id = attraction_id
Where Booking.booking_id = @booking_id";

//         using (SqlConnection connection = new SqlConnection(_connectionString))
//         using (SqlCommand command = new SqlCommand(cmd, connection))
//         {
//             await connection.OpenAsync();
//             command.Parameters.AddWithValue("@booking_id", BookingId);
//         
//             using (var reader = await command.ExecuteReaderAsync())
//             {
//                 while (await reader.ReadAsync())
//                 {
//                    
//                 }
//             }
//         }
//         
//         return dto;
//    }
//    
//    public async Task CreateBookingAsync(DTO DTO)
//    {
//        using SqlConnection connection = new SqlConnection(_connectionString);
//        await connection.OpenAsync();
//    
//        using SqlTransaction transaction = connection.BeginTransaction();
//        using SqlCommand command = new SqlCommand("", connection, transaction);
//    
//        try
//        {
//    command.CommandText = 
//    command.Parameters.AddWithValue);
//    var count = (int)await command.ExecuteScalarAsync();
//        if (count > 0)
//    {
//        throw new ConflictException("Booking already exists");
//    }
//    command.Parameters.Clear()
//    command.CommandText = @"
//             INSERT INTO Booking (booking_id, guest_id, employee_id)
//             VALUES (
//                 @BookingId,
//                 @GuestId,
//                 (SELECT employee_id FROM Employee WHERE employee_number = @EmployeeNumber)
//             )";
//    command.Parameters.AddWithValue("@BookingId", BookingDTO.BookingId);
//    command.Parameters.AddWithValue("@GuestId", BookingDTO.GuestId);
//    command.Parameters.AddWithValue("@EmployeeNumber", BookingDTO.EmployeeNumber);
//    await command.ExecuteNonQueryAsync();
//    await transaction.CommitAsync();
// }
// catch
// {
//             
// await transaction.RollbackAsync();
//     throw;
// }
}
