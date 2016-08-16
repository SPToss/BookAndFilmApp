using DataTransfer;
using Domain.Objects.Abstracts;
using System;


namespace Domain.Objects
{
    public class Film : DataItemBase
    {





        public static Film FromDto(FilmDto film)
        {
            return new Film
            {

            };
        }
        protected override bool IsDirty()
        {
            throw new NotImplementedException();
        }
    }
}
