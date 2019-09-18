using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int initialNumberOfRaccoons = 3;
            int raccoonsThatWentHome = 2;
            int raccoonsInWoods = initialNumberOfRaccoons - raccoonsThatWentHome;
            Console.WriteLine(raccoonsInWoods);

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            int lessBees = flowers - bees;
            Console.WriteLine(flowers - bees);

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int lonelyPigeon = 1;
            int additionalPigeon = 1;
            Console.WriteLine("Pigeon's eating breadcrumbs = " + (lonelyPigeon + additionalPigeon));

            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int initialOwls = 3;
            int additionalOwls = 2;
            int totalOwls = initialOwls + additionalOwls;
            Console.WriteLine(totalOwls);

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int homeBeaver = 2;
            int swimmingBeaver = 1;
            int remainingHomeBeaver = homeBeaver - swimmingBeaver;
            Console.WriteLine(remainingHomeBeaver);

            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int sittingToucans = 2;
            int newToucans = 1;
            int totalToucans = sittingToucans + newToucans;
            Console.WriteLine(totalToucans);

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrels = 4;
            int nuts = 2;
            int squirrelNutDifference = squirrels - nuts;
            Console.WriteLine(squirrelNutDifference);

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            int quarters = 25;
            int dimes = 10;
            int nickels = 10;
            Console.WriteLine("Mrs. Hilt found " + (quarters + dimes + nickels) + " cents");

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int briersMuffins = 18;
            int macadamsMuffins = 20;
            int flannerysMuffins = 17;
            int totalMuffins = briersMuffins + macadamsMuffins + flannerysMuffins;
            Console.WriteLine(totalMuffins);

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            int yoyo = 24;
            int whistle = 14;
            int totalCost = yoyo + whistle;
            Console.WriteLine(totalCost);

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int totalMarshmallows = largeMarshmallows + miniMarshmallows;
            Console.WriteLine(totalMarshmallows);

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int snowHiltHouse = 29;
            int snowBrecknockSchool = 17;
            int snowDifference = snowHiltHouse - snowBrecknockSchool;
            Console.WriteLine(snowDifference);

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int startingMoneyHilt = 10;
            int toyTruck = 3;
            int pencilCase = 2;
            int remainingMoney = startingMoneyHilt - toyTruck - pencilCase;
            Console.WriteLine(remainingMoney);

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int marbleCollectionJosh = 16;
            int lostMarbles = 7;
            int remainingMarbles = marbleCollectionJosh - lostMarbles;
            Console.WriteLine(remainingMarbles);

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int seashellsMegan = 19;
            int seashellsNeeded = 25 - seashellsMegan;
            Console.WriteLine(seashellsNeeded);

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int bradsBalloonsTotal = 17;
            int redBalloons = 8;
            int greenBalloons = bradsBalloonsTotal - redBalloons;
            Console.WriteLine(greenBalloons);

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int booksOnShelf = 38;
            int additionalBooks = 10;
            int totalBooksOnShelf = booksOnShelf + additionalBooks;
            Console.WriteLine(totalBooksOnShelf);

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int beeLegsTotal = beeLegs * 8;
            Console.WriteLine(beeLegsTotal);

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal iceCreamConePrice = .99M;
            decimal totalCostCones = iceCreamConePrice * 2;
            Console.WriteLine(totalCostCones);

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int totalRocksNeeded = 125;
            int totalRocksOwned = 64;
            int rocksNeededForBorder = totalRocksNeeded - totalRocksOwned;
            Console.WriteLine(rocksNeededForBorder);

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int hiltsMarbles = 38;
            int marblesLost = 15;
            int totalMarblesLeft = hiltsMarbles - marblesLost;
            Console.WriteLine(totalMarblesLeft);

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int totalMiles = 78;
            int milesDriven = 32;
            int remainingMiles = totalMiles - milesDriven;
            Console.WriteLine(remainingMiles);

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int snowMorningMinutes = 90;
            int snowAfternoonMinutes = 45;
            int totalHours = ((snowMorningMinutes + snowAfternoonMinutes) / 60);
            int totalMinutes = ((snowMorningMinutes + snowAfternoonMinutes) % 60);
            Console.WriteLine("Total time shoveling is " + totalHours + " Hours and " + totalMinutes + " Minutes");

            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            double hotDogPrice = .50;
            int numberOfHotDogs = 6;
            double hotDogTotalPrice = hotDogPrice * numberOfHotDogs;
            Console.WriteLine(hotDogTotalPrice);

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int hiltTotalCents = 50;
            int pencilCostCents = 7;
            int numberOfPencilsCanPurchase = hiltTotalCents / pencilCostCents;
            Console.WriteLine(numberOfPencilsCanPurchase);

            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterflies - orangeButterflies;
            Console.WriteLine(redButterflies);

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double moneyTendered = 1.00;
            double candyPrice = .54;
            double changeOwed = moneyTendered - candyPrice;
            Console.WriteLine(changeOwed);

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int treesInBackyard = 13;
            int additionalTrees = 12;
            int totalTrees = treesInBackyard + additionalTrees;
            Console.WriteLine(totalTrees);

            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysToSeeGrandma = 2;
            int hoursToSeeGrandma = daysToSeeGrandma * 24;
            Console.WriteLine(hoursToSeeGrandma);

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numberOfCousins = 4;
            int candyPerCousin = 5;
            int totalCandyNeeded = numberOfCousins * candyPerCousin;
            Console.WriteLine(totalCandyNeeded);

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            double dansMoney = 3.00;
            double candyBarPrice = 1.00;
            double dansBalance = dansMoney - candyBarPrice;
            Console.WriteLine(dansBalance);

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boatsInLake = 5;
            int peoplePerBoat = 3;
            int totalPeople = boatsInLake * peoplePerBoat;
            Console.WriteLine(totalPeople);

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int ellensLegosTotal = 380;
            int legosLost = 57;
            int legosRemaining = ellensLegosTotal - legosLost;
            Console.WriteLine(legosRemaining);

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int muffinsBaked = 35;
            int muffinsTotalNeeded = 83;
            int remainingMuffinsToBake = muffinsTotalNeeded - muffinsBaked;
            Console.WriteLine(remainingMuffinsToBake);

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willysCrayons = 1400;
            int lucysCrayons = 290;
            int crayonDifference = willysCrayons - lucysCrayons;
            Console.WriteLine(crayonDifference);

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int numberOfPages = 22;
            int totalStickers = stickersPerPage * numberOfPages;
            Console.WriteLine(totalStickers);

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int cupcakesTotal = 96;
            int totalChildren = 8;
            int cupcakesDivided = cupcakesTotal / totalChildren;
            Console.WriteLine(cupcakesDivided);

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int gingerbreadCookies = 47;
            int remainingCookies = gingerbreadCookies % 6;
            Console.WriteLine(remainingCookies);

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int croissants = 59;
            int remainingCroissants = croissants % 8;
            Console.WriteLine(remainingCroissants);

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int totalOatmealCookies = 276;
            int traysNeeded = totalOatmealCookies / 12;
            Console.WriteLine(traysNeeded);

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int biteSizedPretzels = 480;
            int totalServings = biteSizedPretzels / 12;
            Console.WriteLine(totalServings);

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCupcakes = 53;
            int totalGivenAway = lemonCupcakes - 2;
            int cupcakeBoxes = totalGivenAway / 3;
            Console.WriteLine(cupcakeBoxes);

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotSticks = 74;
            int uneatenCarrotSticks = carrotSticks % 12;
            Console.WriteLine(uneatenCarrotSticks);

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int teddyBears = 98;
            int fullShelves = teddyBears / 7;
            Console.WriteLine(fullShelves);

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int familyPictures = 480;
            int albumsNeeded = familyPictures / 20;
            Console.WriteLine(albumsNeeded);

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int tradingCards = 94;
            int totalFullBoxes = tradingCards / 8;
            int remainingCards = tradingCards % 8;
            Console.WriteLine("Number of Full boxes: " + totalFullBoxes + " and " + remainingCards + " left over.");

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalBooks = 210;
            int booksPerShelf = totalBooks / 10;
            Console.WriteLine(booksPerShelf);

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int totalCroissants = 17;
            double croissantsDivided = totalCroissants / 7D;
            Console.WriteLine(croissantsDivided);

            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */
            double billHourlyRate = (12 * 14) / 2.15;
            double jillHourlyRate = (12 * 14) / 1.90;
            double combinedHourlyRate = billHourlyRate + jillHourlyRate;
            double fiveRoomsDuration = ((12 * 14) * 5) / combinedHourlyRate;
            double durationFor623 = (((12 * 14) * 623) / combinedHourlyRate) / 8;
            Console.WriteLine("It will take " + fiveRoomsDuration + " hours to complete 5 12 x 14 rooms.");
            Console.WriteLine("It will take " + durationFor623 + " days for the pair to paint 623 rooms with 8 hour work days.");

            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */
            string firstName = "Robert";
            string lastName = "Holland";
            string middleInitial = "R";
            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";
            Console.WriteLine(fullName);

            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */
            double percentageCompleted = 537.0 / 800.0;
            int integerPercentageCompleted = (int)(percentageCompleted * 100);
            Console.WriteLine(integerPercentageCompleted);


            Console.ReadLine();

        }
    }
}
