using System;
namespace Booking.Domain.Apartments;

public sealed class Apartment
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Country { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public string City { get; set; }

    public string Street { get; set; }

    public decimal Amount { get; set; }

    public string Currency { get; set; }

    public decimal CleaningFeeAmount { get; set; }

    public string CleaningFeeCurrency { get; set; }

    public DateTime? LastBookedOnUtc { get; set; }

    public List<Amenity> Amenities { get; set; } = new();
}