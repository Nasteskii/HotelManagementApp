# HotelManagementApp
Борче Настески

## 1. Објаснување на проблемот
Апликацијата се користи за одржување на хотел. Може да се додаде хотел, да се уредува, да се додаваат соби, да се уредуваат и бришат истите, и може да се менаџира со резервациите на корисниците. Корисникот може да прегледува соби и да резервира соба во одреден датум. На апликацијата админот може да се регистрира и да се најави за да може да ги користи функционалностите за него. Корисникот не треба да биде најавен, но за да направи резервација, мора да достави свои лични податоци.

## 2. Опис на решението
Во апликацијата се чува објект од класа Scene, таа ги содржи главните функции за работа со хотелот. Содржи објект од класата Hotel, објект од класата Admin и листа од резервации.
Се чуваат информации за хотелот (класа Hotel), собите (класа Room), резервациите (класа Reservation), корисниците (класа User), гостите (класа Guest), админот (класа Admin која наследува од User), тип на кревет(енумерација BedTypes со вредности Single и Double) и број на ѕвезди на хотелот(енумерација StarsNumber).
Со серијализација и десеријализација се зачувуваат и вчитуваат податоците за админот, хотелот и резервациите. Обие објекти се чуваат во .bin датотеки.

## 3. Опис на функции и класи

public void NewHotel(string hotelName, string hotelLocation, byte hotelStars)
{
    List<Room> rooms;
    if (hotel != null)
    {
        rooms = hotel.GetRooms();
    }
    else
    {
        rooms = new List<Room>();
    }
    hotel = new Hotel(hotelName, hotelLocation, hotelStars);
    hotel.AddRooms(rooms);
    

    using (FileStream fileStream = new FileStream(Path.Combine("..", "..", "Data", "hotel.bin"), FileMode.Create))
    {
        IFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fileStream, hotel);
    }
}

- Оваа функција е дел од класата Scene која служи за додавање и уредување на хотел. Прво се проверува дали во апликацијата веќе постои хотел и ако постои се прави објект од класата Hotel со новите податоци за него, како име, локација и бројот на ѕвезди, се додаваат и собите кои се преземаат од веќе постоечкиот објект. Потоа се зачувува новиот објект на местото на стариот и се врши едитирање на информациите. Ако не постои хотел во апликацијата, се прави нов објект со податоци за хотелот, но собите ќе бидат празна листа. Потоа се зачувува новиот објект.


public class Reservation
{
    private User ReservationUser { get; set; }
    private int RoomNumber { get; set; }
    private List<Guest> Guests { get; set; }
    private DateTime CheckInDate { get; set; }
    private DateTime CheckOutDate { get; set; }


    public Reservation(User user, int roomNumber, List<Guest> guests, DateTime checkInDate, DateTime checkOutDate)
    {
        ReservationUser = user;
        RoomNumber = roomNumber;
        Guests = guests;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
    }

    public User GetReservationUser()
    {
        return ReservationUser;
    }

    public int GetRoomNumber()
    {
        return RoomNumber;
    }

    public List<Guest> GetGuests()
    {
        return Guests;
    }

    public DateTime GetCheckInDate()
    {
        return CheckInDate.Date;
    }

    public DateTime GetCheckOutDate()
    {
        return CheckOutDate.Date;
    }
}

- Оваа класа е резервацијата во апликацијата. Во неа се чува корисникот кој ја направил, собата за која е направена, гостите кои ќе доаѓаат и checkIn и checkOut датуми. Со конструкторот со аргументи се иницијализираат променливите во класата и потоа со Get методи може да се влечат податоците.


public static class ValidationUtil
{
    public static bool NameValidation(string name)
    {
        if (name.Trim().Length == 0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    public static bool LocationValidation(string location)
    {
        if (location.Trim().Length == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static bool EmailValidation(string email)
    {
        if (email.Trim().Length == 0)
        {
            return false;
        }
        else
        {
            try
            {
                var emailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public static bool PasswordValidation(string password)
    {
        if (password.Trim().Length > 6)
        {
            bool containsNumber = false;
            foreach (char character in password.ToCharArray())
            {
                if (char.IsDigit(character))
                {
                    containsNumber = true;
                    break;
                }
            }
            if (password.Trim() != password.ToLower() && containsNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }

    public static bool DateValidation(DateTime checkIn, DateTime checkOut)
    {
        if (!checkIn.Equals(checkOut) && checkIn >= DateTime.Now.AddMinutes(-5) && checkOut >= DateTime.Now.AddMinutes(-5) && checkOut > checkIn)
        {
            return true;
        }
        return false;
    }
}

- Во оваа статичка util класа се содржат методи за валидација на податоците кои се внесуваат. Има методи за валидација на име, локација, емаил, лозинка и датум.


## 4. Упатство за користење
![Screenshot_1](https://github.com/Nasteskii/HotelManagementApp/assets/86986540/243a9684-11af-4709-9737-f951871395aa)

Ова е изгледот на првата форма каде не е внесен хотел и не е регистриран админ.
За да може да се внесе хотел и да се управува со него, потребно е да се регистрира админ и да се најави.

Кога админот ќе се регистрира и најави, на формата се прикажуваат опциите кои му се достапни.

![Screenshot_2](https://github.com/Nasteskii/HotelManagementApp/assets/86986540/41be965f-75a5-4f70-bc5f-b6db8d94d310)

Со клик на копчето New Hotel, му се отвора нова форма во која внесува податоци за хотелот и го зачувува.

Потоа може да управува со собите и со резервациите, но и да ги променува информациите за хотелот. 

![Screenshot_3](https://github.com/Nasteskii/HotelManagementApp/assets/86986540/e35f11d8-ac7c-4d97-86f3-1dd8f163448b)

![Screenshot_6](https://github.com/Nasteskii/HotelManagementApp/assets/86986540/c7984092-a5c5-4b37-916d-fd5ddf4a2a96)


За да може корисникот да ги прегледува собите, мора прво да се додадат од страна на админот.
Со клик на копчето Search Rooms од почетниот екран, му се прикажува нова форма со сите соби.

![Screenshot_4](https://github.com/Nasteskii/HotelManagementApp/assets/86986540/05ad8ead-fbcf-44ac-b6bd-648ebc9eccff)


Кога ќе притисе на копчето Book од некоја соба, му се отвора нова форма во која може да внесе информации за резервацијата.

![Screenshot_5](https://github.com/Nasteskii/HotelManagementApp/assets/86986540/f21638f7-1f09-4dd2-af2e-632f1efce546)

Потребно е да внесе мејл, име, презиме, број на гости (вклучувајќи го и него), години на гостите и Check In и Check Out датуми.
Корисникот неможе да резервира соба која веќе е резервирана на тој датум, неможе да резервира соба пред тогашниот датум и датумот на напуштање на собата треба да биде после датумот на пристигнување.
