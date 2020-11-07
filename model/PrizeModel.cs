namespace model
{
 public   class PrizeModel : BaseModel
    {
        /// <summary>
        /// Represents the place number for this prize amount
        /// </summary>
        public int PlaceNumber { get; }
        /// <summary>
        /// Represents the place number is formally called such as 
        /// Winner , Runner up etc.
        /// </summary>
        public string PlaceName { get; }
        /// <summary>
        /// Represents the prize money to be awarded for this particular place number
        /// </summary>
        public decimal PrizeMoney { get; }
        /// <summary>
        /// Represents the prize money as in percentage of total tournament prize amount for
        /// this particular place number
        /// </summary>
        public double PrizePercentage { get; }

        public PrizeModel ( int placeNumber,
                           string placeName,
                           decimal prizeMoney,
                           double prizePercentage ) : base ()
        {
            PlaceNumber = placeNumber;
            PlaceName = placeName;
            PrizeMoney = prizeMoney;
            PrizePercentage = prizePercentage;



        }

        public PrizeModel ( int id,
                           int placeNumber,
                           string placeName,
                           decimal prizeMoney,
                           double prizePercentage ) : base ( id )
        {
            PlaceNumber = placeNumber;
            PlaceName = placeName;
            PrizeMoney = prizeMoney;
            PrizePercentage = prizePercentage;



        }
    }
}
