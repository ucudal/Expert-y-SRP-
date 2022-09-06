using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(Paciente paciente, string id, DateTime date, string appoinmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
            
           if(paciente==null)
           {
                stringBuilder.Append("Unable to schedule appointment, 'paciente' is required\n");
                isValid = false;
           }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (doctor==null)
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }
    }
    public class Paciente{
        private string name;
        private string phoneNumber;

        public Paciente(string name,string phoneNumber){
            Name=name;
            PhoneNumber=phoneNumber;
        }
        public string Name{
            get{return name;}
            set{
                if(string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Paciente, 'name' is required\n");
                }
                name=value;
            }
        }
        public string PhoneNumber
        {
            get{
                return phoneNumber;
            }
            set{
                if (string.IsNullOrEmpty(phoneNumber))
                {
                    throw new ApplicationException("Paciente, 'phone number' is required\n");
                }
            }
        }
    }

    public class Doctor
    {
        private string name;

        public Doctor(string name)
        {
            Name=name;
        }

        public string Name{
            get{
                return name;
            }
            set{
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Doctor, 'name' is required\n");
                }
                name=value;
            }
        }     
    }
}
