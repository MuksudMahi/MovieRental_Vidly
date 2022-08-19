using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vividly.Models;

namespace Vividly.View_Models
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}