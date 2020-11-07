namespace model
{
  public  class PersonModel : BaseModel
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string EmailAddress { get; }
        public string CellPhoneNumber { get; }

        public PersonModel ( string firstName,
                            string lastName,
                            string emailAddress,
                            string cellphoneNumber ) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CellPhoneNumber = cellphoneNumber;

        }

        public PersonModel ( int id,
                            string firstName,
                            string lastName,
                            string emailAddress,
                            string cellphoneNumber ) : base (id)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CellPhoneNumber = cellphoneNumber;

        }
    }
}

