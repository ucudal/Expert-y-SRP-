using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           

            try{
                Paciente paciente1=new Paciente("Steven Jhonson","5555-555-555");
                Doctor doctor1=new Doctor("Armand");
                string appointmentResult = AppointmentService.CreateAppointment( paciente1,"986782342",  DateTime.Now, "Wall Street" ,doctor1);
                Console.WriteLine(appointmentResult);
                Paciente paciente2=new Paciente("Ralf Manson","5555-555-555");
                Doctor doctor2=new Doctor("");
                string appointmentResult2 = AppointmentService.CreateAppointment(paciente2,"",  DateTime.Now, "Queen Street", doctor2);
                Console.WriteLine(appointmentResult2);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
