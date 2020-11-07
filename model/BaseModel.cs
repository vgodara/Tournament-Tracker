using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
  public  class BaseModel
    {
        public int Id { get; }

        public BaseModel ( ) {
            Id = int.MinValue;
        }
        public BaseModel ( int id ) {
            Id = id;
        }
    }
}
