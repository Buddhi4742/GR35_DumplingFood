using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// /////////////////////////////////////////////car.cs model
/// </summary>
namespace Dumpling_Food.Models.User
{
    public class LoginModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("custUsername")]
        [Required]
        public string userName{ get; set; }

        [BsonElement("custPassword")]
        [Required]
        public string password { get; set; }

        [BsonElement("custName")]
        [Required]
        public string custName { get; set; }

        //[BsonElement("Year")]
        //[Required]
        //[YearRange]
        //public int Year { get; set; }

        //[BsonElement("Price")]
        //[Display(Name = "Price($)")]
        //[DisplayFormat(DataFormatString = "{0:#,0}")]
        //public decimal Price { get; set; }

        //[BsonElement("ImageUrl")]
        //[Display(Name = "Photo")]
        //[DataType(DataType.ImageUrl)]
        //[Required]
        //public string ImageUrl { get; set; }


    }
}
