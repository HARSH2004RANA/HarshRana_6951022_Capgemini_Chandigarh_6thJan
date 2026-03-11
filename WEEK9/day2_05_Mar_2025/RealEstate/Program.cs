namespace RealEstate
{
    public class RealEstateListing
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
    }

    // Class to manage listings
    public class RealEstateApp
    {
        private List<RealEstateListing> listings = new List<RealEstateListing>();

        // Add listing
        public void AddListing(RealEstateListing listing)
        {
            listings.Add(listing);
        }

        // Remove listing by ID
        public void RemoveListing(int listingID)
        {
            var listing = listings.FirstOrDefault(x => x.ID == listingID);

            if (listing != null)
            {
                listings.Remove(listing);
            }
        }

        // Update listing
        public void UpdateListing(RealEstateListing listing)
        {
            var existingListing = listings.FirstOrDefault(x => x.ID == listing.ID);

            if (existingListing != null)
            {
                existingListing.Title = listing.Title;
                existingListing.Description = listing.Description;
                existingListing.Price = listing.Price;
                existingListing.Location = listing.Location;
            }
        }

        // Get all listings
        public List<RealEstateListing> GetListings()
        {
            return listings;
        }

        // Get listings by location
        public List<RealEstateListing> GetListingsByLocation(string location)
        {
            return listings
                .Where(x => x.Location.Equals(location, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Get listings by price range
        public List<RealEstateListing> GetListingsByPriceRange(int minPrice, int maxPrice)
        {
            return listings
                .Where(x => x.Price >= minPrice && x.Price <= maxPrice)
                .ToList();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            RealEstateApp app = new RealEstateApp();

            // Adding listings
            app.AddListing(new RealEstateListing
            {
                ID = 1,
                Title = "Luxury Villa",
                Description = "5 BHK Villa with garden",
                Price = 900000,
                Location = "Delhi"
            });

            app.AddListing(new RealEstateListing
            {
                ID = 2,
                Title = "City Apartment",
                Description = "2 BHK apartment",
                Price = 400000,
                Location = "Mumbai"
            });

            app.AddListing(new RealEstateListing
            {
                ID = 3,
                Title = "Farmhouse",
                Description = "Farmhouse with large land",
                Price = 700000,
                Location = "Delhi"
            });

            // Display all listings
            Console.WriteLine("All Listings:");
            foreach (var listing in app.GetListings())
            {
                Console.WriteLine($"{listing.ID} {listing.Title} {listing.Price} {listing.Location}");
            }

            // Update listing
            app.UpdateListing(new RealEstateListing
            {
                ID = 2,
                Title = "Modern Apartment",
                Description = "Updated 2 BHK apartment",
                Price = 450000,
                Location = "Mumbai"
            });

            // Remove listing
            app.RemoveListing(1);

            Console.WriteLine("\nListings After Update and Remove:");
            foreach (var listing in app.GetListings())
            {
                Console.WriteLine($"{listing.ID} {listing.Title} {listing.Price} {listing.Location}");
            }

            // Filter by location
            Console.WriteLine("\nListings in Delhi:");
            var delhiListings = app.GetListingsByLocation("Delhi");

            foreach (var listing in delhiListings)
            {
                Console.WriteLine($"{listing.Title} {listing.Price}");
            }

            // Filter by price range
            Console.WriteLine("\nListings between 400000 and 800000:");

            var priceListings = app.GetListingsByPriceRange(400000, 800000);

            foreach (var listing in priceListings)
            {
                Console.WriteLine($"{listing.Title} {listing.Price}");
            }
        }
    }
}
