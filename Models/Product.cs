using System;
using System.Collections.Generic;

namespace Product_CQRS_SingleFile_MediatR.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; }

    public string ProductDescription { get; set; }

    public string ProductCategory { get; set; }

    public double ProductPrice { get; set; }
}
