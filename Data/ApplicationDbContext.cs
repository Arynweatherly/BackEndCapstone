using System;
using System.Collections.Generic;
using System.Text;
using BackEndCapstone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackEndCapstone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Gemstone> Gemstone { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Tutorial> Tutorial { get; set; }
        public DbSet<TutorialReview> TutorialReview { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            ApplicationUser user = new ApplicationUser
            {

                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            ApplicationUser user2 = new ApplicationUser
            {

                FirstName = "aryn",
                LastName = "weatherly",
                UserName = "aryn@aryn.com",
                NormalizedUserName = "ARYN@ARYN.COM",
                Email = "aryn@aryn.com",
                NormalizedEmail = "ARYN@ARYN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "10000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash2 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash2.HashPassword(user2, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user2);


            ApplicationUser user3 = new ApplicationUser
            {

                FirstName = "sage",
                LastName = "klein",
                UserName = "sage@sage.com",
                NormalizedUserName = "SAGE@SAGE.COM",
                Email = "sage@sage.com",
                NormalizedEmail = "SAGE@SAGE.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "01000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash3 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash3.HashPassword(user3, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user3);


            ApplicationUser user4 = new ApplicationUser
            {

                FirstName = "heidi",
                LastName = "smith",
                UserName = "heidi@heidi.com",
                NormalizedUserName = "HEIDI@HEIDI.COM",
                Email = "heidi@heidi.com",
                NormalizedEmail = "HEIDI@HEIDI.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00100000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash4 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash4.HashPassword(user4, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user4);




            Gemstone Amazonite = new Gemstone()
            {
                Id = 1,
                Title = "Amazonite",
                ImagePath = "Amazonite.gif",
                Description = "amazonite mineral rock was treasured by the ancient egyptians who made beautiful jewelry, ornamental pieces and carved important texts into this stone. amazonite has always been prized for its beauty and healing power. this pale green mineral rock is believed to date back as far as the 10th century bc.amazonite is usually pale green, but can sometimes be blue-green, turquoise or yellow-green and can also have white streaks. the color of amazonite is due to the presence of lead within the stone and color variation may exist within a single stone.",
            };
            modelBuilder.Entity<Gemstone>().HasData(Amazonite);


            Gemstone Calcite = new Gemstone()
            {
                Id = 2,
                Title = "Calcite",
                ImagePath = "cacite.jpg",
                Description = "Calcite, also called limespar, is a very common rock-forming mineral. The word calcite comes from the Latin calx and the Greek chalix, which means lime. Calcite has more uses than almost any other mineral. A great deal of calcite is formed from the shells of dead marine organisms. Calcite may also be found in volcanic or mantle-derived rocks. A relatively soft stone, calcite has a Mohs hardness of 3. Calcite is transparent to translucent and may occasionally show phosphorescence or fluorescence.Because of its understated coloring, yellow calcite matches up nicely with antiqued gold-plated brass. It can be a grounding for more flamboyant colors such as carnelian.  "
            };
            modelBuilder.Entity<Gemstone>().HasData(Calcite);

            Gemstone BlueLaceAgate = new Gemstone()
            {
                Id = 3,
                Title = "Blue Lace Agate",
                ImagePath = "blueLace.gif",
                Description = "Blue lace agate is a type of variegated chalcedony, more specifically a variety of quartz. This type of agate is most notably recognized by its predominantly light blue banded layers that have also been known to include bright blue, white and brown hues. Agates typically form as nodules or geodes in igneous rocks.The soft hue of blue lace agate pairs exceptionally well with other pastel-colored gemstones. Looking at the bands of color, pair your blue lace agate with the tones of the bands to draw increased attention to the swirling pattern. For a complementary color pairing, blue lace agate provides a great base to draw attention to orange/red gemstones such as carnelian, sunstone, amber and other forms of agate or banded jaspers."
            };
            modelBuilder.Entity<Gemstone>().HasData(BlueLaceAgate);

            Gemstone PetrifiedCoral = new Gemstone()
            {
                Id = 4,
                Title = "Petrified Coral",
                ImagePath = "coral.jpg",
                Description = "Coral has been called the 'garden of the sea' because it was once believed to be a plant. Instead, coral belongs to a small, but important group of organic gemstones. Coral is formed through a biological process rather than being a mineral with a crystalline structure like most colored stones. Precious coral is a deep water coral that forms in rocky seabeds with low levels of sedimentation, typically in dark environments over 500-feet deep. Coral is very sensitive to acid and heat. Coral's color is known to fade with wear and tear. To prevent color loss, avoid exposing coral to direct sunlight for prolonged periods of time and avoid temperature extremes."

            };
            modelBuilder.Entity<Gemstone>().HasData(PetrifiedCoral);

            Gemstone BlackOnyx = new Gemstone()
            {
                Id = 5,
                Title = "Black Onyx",
                ImagePath = "blackOnyx.jpg",
                Description = "Onyx is a form of chalcedony, which is a microcrystalline quartz formed in the gas cavities of lava. Its multi-layered structure is similar to that of agates. When the stone has a black base and a white upper layer, it's called onyx. (Black onyx is uniformly black chalcedony. Much of what is referred to as 'black onyx' is gray chalcedony that has been chemically treated to be a rich black. Black is neutral, making it a great design element to combine with many different colored stones, other gemstone beads and all metal tones. Its deep, dark, lustrous surface can play a striking contrast to the warm-colored gemstones like garnet, carnelian and coral.) "
            };
            modelBuilder.Entity<Gemstone>().HasData(BlackOnyx);

            Gemstone Lapis = new Gemstone()
            {
                Id = 6,
                Title = "Lapis Lazuli",
                ImagePath = "lapis.jpg",
                Description = "Lapis lazuli is one of the oldest opaque gemstones in history--more than 6,500 years! This deep blue stone includes tiny flecks of mica, like a night sky full of stars. Its most well-known source is deep in the mountains of modern Afghanistan. Lapis lazuli is an intensely blue stone made of a deep blue lazurite, cloudy white calcite, sparkly pyrite and other minerals. This beautiful mixture of textures gives lapis lazuli its characteristic look.Lapis lazuli is found with limestone or as separate boulders. Stones from what is now modern Afghanistan and Pakistan are still considered to be of the best quality. Royal blue lapis lazuli characteristically has either whitish or yellowish matrix or feathering. When it is flecked with white, it is perfectly complemented by silver and turquoise for a Southwestern look. If it has brassy specks, it is regal with gold. Lapis also has darker regions that can be accented when strung with black onyx or antiqued silver beads. "
            };
            modelBuilder.Entity<Gemstone>().HasData(Lapis);

            Gemstone Larimar = new Gemstone()
            {
                Id = 7,
                Title = "Larimar",
                ImagePath = "larimar.jpg",
                Description = "Larimar is a rare blue variety of pectolite. The serene blue color results from the substitution of cobalt for calcium in the stone and varies from white and light-blue to green-blue and deep blue or 'volcanic blue.' With swirling bands of white, larimar mimics the wave crests of crystal blue Caribbean waters.To date, the only known major deposits of larimar are found in the Dominican Republic where it was most likely treasured by the area's first inhabitants, the Taino Indians. Many jewelry artists incorporate polished freeform larimar pendants and cabochons into necklaces and create earrings with larimar rounds and chips. Freeform larimar stones can be used in wire-wrapped designs such as necklaces, rings, bracelets and earrings."
            };
            modelBuilder.Entity<Gemstone>().HasData(Larimar);

            Gemstone Sunstone = new Gemstone()
            {
                Id = 8,
                Title = "Sunstone",
                ImagePath = "sunstone.jpg",
                Description = "Sunstone began as a costly and little-known gemstone until deposits were found in Norway and Siberia. This gemstone has a special history in the United States, however, where sunstone varieties called 'heliolite' have been mined in Oregon. Sunstone gems belong to the feldspar group, which encompasses a large variety of gemstone materials--including moonstone and amazonite. The sparkly metallic glitter in this particular feldspar is called aventurescence, which is caused by flat, reflective inclusions (sometimes called 'schiller'). These inclusions can be hematite, copper or other minerals. Larger inclusions tend to be more glittery while small inclusions create a red or gold sheen on top of the stone's natural color. Sunstone, with its rich, earthy red-orange tones, works great in settings of all metal tones. You can't go wrong pairing sunstone with silver, gold, rose gold, copper or other metals. Pair with moonstone to draw attention to the schiller flash in both of these feldspar minerals. Create a complementary color scheme for high contrast and drama by pairing sunstone with emerald green and lapis lazuli blue "
            };
            modelBuilder.Entity<Gemstone>().HasData(Sunstone);

            Gemstone Lepidolite = new Gemstone()
            {
                Id = 9,
                Title = "Lepidolite",
                ImagePath = "Lepidolite.jpg",
                Description = "Lepidolite is mined as a source of the element lithium along with other rare earth elements such as cesium and rubidium. Lepidolite is an important source of lithium, which is the lightest metal in the world. Lepidolite is a translucent to transparent rose to purple colored phyllosilicate mineral of the mica group. Lepidolite is associated with other lithium-bearing minerals like spodumene in pegmatite bodies. It is one of the major sources of the rare alkali metals rubidium and cesium. It is found most often as small, scaly crystals in dense aggregates. It is also found in masses and groupings such as foliated, flaky and scaly forms.With its variety of hues from pinkish rose to purple along with other shades, lepidolite offers more tonal flexibility that you might think at first glance. For a slight contrast, consider pairing lepidolite with the lighter rose quartz. "
            };
            modelBuilder.Entity<Gemstone>().HasData(Lepidolite);

            Gemstone RoseQuartz = new Gemstone()
            {
                Id = 10,
                Title = "Rose Quartz",
                ImagePath = "roseQuartz.jpg",
                Description = " Quartz includes a large group of minerals based on silicon dioxide. Rose quartz is a macrocrystalline form, as are amethyst, aventurine and citrine. It is a milky pink color, often crackled, and found mainly in large clumps. Only rarely is it found in single crystal form. It is believed that the pink color is due to a small amount of titanium.Rose quartz is found in pegmatite, a course-grained igneous rock (usually granite). Transparent rose quartz is rare, but is found where the best material comes from: Madagascar.Rose quartz is typically a cloudy translucent pink or slightly peach color. The violet of amethyst, either light or dark, is close to pink on the color wheel, and makes for a lovely two-color scheme set in silver. For a beautifully cool split-complementary color scheme, match rose quartz with grass-green peridot and frosty blue-green amazonite."
            };
            modelBuilder.Entity<Gemstone>().HasData(RoseQuartz);

            Gemstone Opal = new Gemstone()
            {
                Id = 11,
                Title = "Opal",
                ImagePath = "opal2.jpg",
                Description = "Opals come in three natural varieties: opalescent precious opal, fire opal (yellow to red-orange) and the generally opaque common opal. A French manufacturer, Gilson, created the first 'opalescent' imitation opal in 1973 though synthetic opals have been created since the '30s. Natural opals are non-crystalline, hydrated silicon dioxide gemstones that contain up to 30% water. It's possible for opals to dry out and crack, and they are relatively soft, fragile gemstones. Precious opals display a unique opalescence. Depending on the angle of view, rainbow-like flashes of different colors appear, caused by light reflecting off of extremely small spheres of cristobalite within the silica gel. The phenomenon is called interference. The flashing of color is often referred to as 'fire' or 'play of light.' Precious opals appear in a range of white to black (usually dark gray, green or blue backgrounds)."
            };
            modelBuilder.Entity<Gemstone>().HasData(Opal);

            Gemstone AutumnJasper = new Gemstone()
            {
                Id = 12,
                Title = "Autumn Jasper",
                ImagePath = "autumnJasper.jpg",
                Description = "Jasper, an opaque chalcedony, comes in a wide variety of colors, each with unique patterning. Autumn jasper is the variety of jasper known for its mottled warm brick red and avocado green appearance. The term 'jasper' itself comes from the Greek work iaspi, which means 'spotted stone.' Jasper gemstones are found all over the world, but raw autumn jasper materials are often found in India, Madagascar and South Africa.  "
            };
            modelBuilder.Entity<Gemstone>().HasData(AutumnJasper);

            Gemstone Jasper = new Gemstone()
            {
                Id = 13,
                Title = "Jasper",
                ImagePath = "jasper.jpg",
                Description = "The unique artistry of Jasper is that of Nature itself - golden sunshine, a nighttime sky, poppy fields or a deep green forest, desert sands, the undulating ocean, red rock canyons, sweeping mountains. Each stone is a masterpiece of the Creator, bold and primitive in style, solid and earthy in form, with a warm, harmonious energy that resonates with the primal self.There is a wide variety of Jaspers, characterized by color, form, and similarities to places or animals found in nature. Many are named for the regions where they are mined; others are named by those who discovered them. Though far too extensive to cover here, we will mention a few of the more popular and familiar Jaspers, some with their own pages and additional metaphysical properties. Multi-colored Jasper carries the properties of its dominant color, or colors, while still drawing energies from its subtle hues."
            };
            modelBuilder.Entity<Gemstone>().HasData(Jasper);

            Gemstone Pearl = new Gemstone()
            {
                Id = 14,
                Title = "Pearl",
                ImagePath = "pearl.jpg",
                Description = "Pearls are one of a few natural or organic gemstones (others include coral, amber, jet and mother-of-pearl). Produced by the pearl oyster and the freshwater pearl mussel, natural pearls are a small irritant within the oyster or mussel which has been coated with nacre to reduce that irritation. Pearls created by a pearl farmer, who inserts a tiny piece, or 'seed' of mother-of-pearl into a freshwater pearl oyster. The pearl oyster will coat the seed with progressive layers of nacre, creating a pearl. Tennessee has been the leading state for cultured freshwater pearl production since the 1960s."
            };
            modelBuilder.Entity<Gemstone>().HasData(Pearl);


            Gemstone AquaQuartz = new Gemstone()
            {
                Id = 15,
                Title = "Aqua Quartz",
                ImagePath = "aquaqtz.jpg",
                Description = "Aqua Aura Quartz is a beautiful bright blue quartz crystal created from the result of a special process involving gold. The crystals are heated and fine vaporized gold is bonded to the crystal’s surface. It is considered by many to have a high vibration and to aid communication and psychic skills."
            };
            modelBuilder.Entity<Gemstone>().HasData(AquaQuartz);





            ProductType Earring = new ProductType()
            {
                Id = 1,
                Category = "Earrings",
            };
            modelBuilder.Entity<ProductType>().HasData(Earring);

            ProductType Necklace = new ProductType()
            {
                Id = 2,
                Category = "Necklaces",
            };
            modelBuilder.Entity<ProductType>().HasData(Necklace);

            ProductType Bracelet = new ProductType()
            {
                Id = 3,
                Category = "Bracelets",
            };
            modelBuilder.Entity<ProductType>().HasData(Bracelet);



            Product CalciteTriangleEarrings = new Product()
            {
                Id = 1,
                Title = "Calcite Triangle Earrings",
                GemstoneId = 2, 
                ImagePath = "TriangleCalciteEarrings.jpg",
                ProductTypeId = 1,
                Description = "Rustic triangle shaped copper earrings with large, round calcite gemstone.",
               
         
            };
            modelBuilder.Entity<Product>().HasData(CalciteTriangleEarrings);



            Product BlackOnyxEarrings = new Product()
            {
                Id = 2,
                Title = "Black Onyx Dangle Earrings",
                ImagePath = "BlackOnyxDangle.jpg",
                GemstoneId = 5,
                ProductTypeId = 1,
                Description = "Elegant sterling silver and black onyx dangle earrings.",


            };
            modelBuilder.Entity<Product>().HasData(BlackOnyxEarrings);



            Product PinkBlueTassleEarrings = new Product()
            {
                Id = 3,
            
                GemstoneId = 13,
                ProductTypeId = 1,
                Title = "Pink and Blue Jasper Tassle Earrings",
                ImagePath = "blueJasperTassle.jpg",
                Description = "Trendy tassle earrings with all natural pink and coral jasper gemstones.",


            };
            modelBuilder.Entity<Product>().HasData(PinkBlueTassleEarrings);



            Product LepidoliteHoops = new Product()
            {
                Id = 4,

                GemstoneId = 9,
                ProductTypeId = 1,
                Title = "Lepidolite Gold Hoops",
                ImagePath = "LepidoliteChipHoops.jpg",
                Description = "Hammered out gold hoop earrings with wire-wrapped lepidolite chips.",


            };
            modelBuilder.Entity<Product>().HasData(LepidoliteHoops);



            Product CoralHoops = new Product()
            {
                Id = 5,
                GemstoneId = 4,
                ProductTypeId = 1,
                Title = "Gold Hoop Earrings With Petrified Coral",
                ImagePath = "coralHoops.jpg",
                Description = "Hammered out gold hoops with wire wrapped pieces of petrified coral.",


            };
            modelBuilder.Entity<Product>().HasData(CoralHoops);



            Product HammeredGoldAndChainEarrings = new Product()
            {
                Id = 6,
                ProductTypeId = 1,
                Title = "Gold and Bronze Chain Earrings",
                ImagePath = "GoldBronzeChainEarrings.jpg",
                Description = "Hammered out gold earrings with bronze chain.",


            };
            modelBuilder.Entity<Product>().HasData(HammeredGoldAndChainEarrings);



            Product BlackTassleEarrings = new Product()
            {
                Id = 7,
                ProductTypeId = 1,
                Title = "Teardrop Black Tassle Earrings",
                ImagePath = "GoldTeardropBlackTassle.jpg",
                Description = "Teardrop shaped gold earrings with black tassles.",


            };
            modelBuilder.Entity<Product>().HasData(BlackTassleEarrings);



            Product DiamondLarimarEarrings = new Product()
            {
                Id = 8,
                GemstoneId = 7,
                ProductTypeId = 1,
                Title = "Diamond Shaped Hoops with Larimar Gemstones",
                ImagePath = "DiamondLarimarEarrings.jpg",
                Description = "Hammered out diamond shaped gold hoops with wire wrapped larimar gemstones.",


            };
            modelBuilder.Entity<Product>().HasData(DiamondLarimarEarrings);



            Product AmazoniteSterlingEarrings = new Product()
            {
                Id = 9,
                GemstoneId = 1,
                ProductTypeId = 1,
                Title = "Sterling Silver and Amazonite Earrings",
                ImagePath = "SterlingAmazoniteEarrings.jpg",
                Description = "Asymmetrical sterling silver bead frames with rare cut amazonite gemstones."

            };
            modelBuilder.Entity<Product>().HasData(AmazoniteSterlingEarrings);



            Product PinkOpalCopperHoops = new Product()
            {
                Id = 10,
                GemstoneId = 11,
                ProductTypeId = 1,
                Title = "Copper Hoops with Pink Opal",
                ImagePath = "BronzePinkOpalHoops.jpg",
                Description = "Hammered out copper hoop earrings with wire wrapped pink opal gemstones."


            };
            modelBuilder.Entity<Product>().HasData(PinkOpalCopperHoops);


            Product FramedAutumnJasperEarrings = new Product()
            {
                Id = 11,
                GemstoneId = 12,
                ProductTypeId = 1,
                Title = "Framed Autumn Jasper Earrings",
                ImagePath = "AutumnJasperFramed.jpg",
                Description = "Rare cut autumn jasper gemstones set inside sterling silver bead frame."
            };
            modelBuilder.Entity<Product>().HasData(FramedAutumnJasperEarrings);

            Product BlueLaceGoldHoops = new Product()
            {
                Id = 12,
                GemstoneId = 3,
                ProductTypeId = 1,
                Title = "Gold Hoops with Blue Lace Agate",
                ImagePath = "BlueLaceHoops.jpg",
                Description = "Hammered out gold hoop earrings wire wrapped with chips of blue lace agate."
            };
            modelBuilder.Entity<Product>().HasData(BlueLaceGoldHoops);


            Product InvertedTeardropLepidolite = new Product()
            {
                Id = 13,
                GemstoneId = 9,
                ProductTypeId = 1,
                Title = "Inverted Teardop Lepidolite Earrings",
                ImagePath = "InvertedTeardropLarimar.jpg",
                Description = "Inverted gold teardrop earrings with wire wrapped lepidolite gemstones."
            };
            modelBuilder.Entity<Product>().HasData(InvertedTeardropLepidolite);


            Product LapisHoops = new Product()
            {
                Id = 14,
                GemstoneId = 6,
                ProductTypeId = 1,
                Title = "Gold Hoop Lapis Earrings",
                ImagePath = "LapisHoopEarrings.jpg",
                Description = "Gold hoop earrings accented with wire wrapped, teardrop shaped lapis gemstone."
            };
            modelBuilder.Entity<Product>().HasData(LapisHoops);


            Product RoseQuartzTeardrops = new Product()
            {
                Id = 15,
                GemstoneId = 10,
                ProductTypeId = 1,
                Title = "Gold Teardrop Earrings with Rose Quartz",
                ImagePath = "RoseGoldTeardrop.jpg",
                Description = "Hammered out gold teardrop earrings with wire wrapped chips of rose quartz."
            };
            modelBuilder.Entity<Product>().HasData(RoseQuartzTeardrops);

            Product AquaQuartzHoops = new Product()
            {
                Id = 16,
                GemstoneId = 15,
                ProductTypeId = 1,
                Title = "Gold Hoop earrings with Aqua Quartz Gemstone",
                ImagePath = "AquaQuartzGoldHoops.jpg",
                Description = "Hammered out gold hoop earrings with rare cut aqua quartz gemstones."
            };
            modelBuilder.Entity<Product>().HasData(AquaQuartzHoops);
        }
    }
}
