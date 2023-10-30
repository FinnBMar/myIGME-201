using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Test
{
    public abstract class Phone
    {
        private string phoneNumber; //fields
        public string address;

        public string PhoneNumber //property
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public abstract void Connect();
        public abstract void Disconnect();
    }
    public interface PhoneInterface
    {
        //methods
        void Answer();
        void MakeCall();
        void HangUp();
    }
    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {
            Console.WriteLine("Hello?");
        }
        public void MakeCall()
        {
            Console.WriteLine("*dialtone* Enter a valid phone number");
            string CallerID = Console.ReadLine();
            Console.WriteLine("Calling " + CallerID);
        }
        public void HangUp()
        {
            Console.WriteLine("Call Ended");
        }
        public override void Connect()
        {
            Console.WriteLine("Patching you through");
        }
        public override void Disconnect()
        {
            Console.WriteLine("Goodbye.");
        }
    }
    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver; //fields
        private byte whichDoctorWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDoctorWho
        {
            get
            {
                return this.whichDoctorWho;
            }
        }
        public string FemaleSideKick
        {
            get
            {
                return this.femaleSideKick;
            }
        }
        public void TimeTravel()
        {
            Console.WriteLine("Please select a time to travel to.");
        }
        public static bool operator ==(Tardis t1, Tardis t2) //checking each condition and adjusting the output if conditions are met or not met.
        {
            if (t1.whichDoctorWho == t2.whichDoctorWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Tardis t1, Tardis t2)
        {
            if (t1.whichDoctorWho == t2.whichDoctorWho)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator >(Tardis t1, Tardis t2)
        {
            if ((t1.whichDoctorWho > t2.whichDoctorWho) || (t1.whichDoctorWho == 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Tardis t1, Tardis t2)
        {
            if ((t1.whichDoctorWho < t2.whichDoctorWho) || (t2.whichDoctorWho == 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Tardis t1, Tardis t2)
        {
            if ((t1.whichDoctorWho <= t2.whichDoctorWho) || (t2.whichDoctorWho == 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Tardis t1, Tardis t2)
        {
            if ((t1.whichDoctorWho >= t2.whichDoctorWho) || (t1.whichDoctorWho == 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {
            Console.WriteLine("Hello?");
        }
        public void MakeCall()
        {
            Console.WriteLine("*dialtone* Enter a valid phone number");
            string CallerID = Console.ReadLine();
            Console.WriteLine("Calling " + CallerID);
        }
        public void HangUp()
        {
            Console.WriteLine("Call Ended");
        }
        public override void Connect()
        {
            Console.WriteLine("Patching you through");
        }
        public override void Disconnect()
        {
            Console.WriteLine("Goodbye.");
        }
    }
    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan; 
        public double costPerCall;
        public bool phoneBook;
        
        public void OpenDoor() 
        {
            Console.WriteLine("Door open");
        }

        public void CloseDoor()
        {
            Console.WriteLine("Door closed");
        }
    }
    internal class Program
    {
        static void UsePhone(object obj)
        {
            PhoneInterface phone;//creating each object
            PhoneBooth phoneBooth;
            Tardis tardis; 
            if (obj is PhoneInterface) //changes functionality after checking what type of object it is
            {
                phone = (PhoneInterface)obj;//casts object to phoneInterface
                phone.MakeCall();
                phone.HangUp();
            }
            if (obj is PhoneBooth)
            {
                phoneBooth = (PhoneBooth)obj;
                phoneBooth.OpenDoor();
            }
            if (obj is Tardis)
            {
                tardis = (Tardis)obj;
                tardis.TimeTravel();
            }
        }
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();
        }
    }
}