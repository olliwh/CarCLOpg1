namespace CarCLOpg1
{
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public string? LicensePlate { get; set; }

        
        public void ValidateModel()
        {
            if (Model?.Length < 4) throw new ArgumentException();
        }
        public void ValidatePrice()
        {
            if(Price <= 0) throw new ArgumentOutOfRangeException();
        }
        public void ValidateLicensePlate()
        {
            if (LicensePlate?.Length < 2 || LicensePlate?.Length > 7) throw new ArgumentException();
        }
        public void Validate()
        {
            ValidateLicensePlate();
            ValidateModel();
            ValidatePrice();
        }
    }
}