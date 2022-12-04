/**
* <author>Christophe Roblin</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no>, Warped Ibun <madbrit@co.uk></credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxLoot))
{
    new ScriptObject(LiFxLoot)
    {
    };
}

package LiFxLoot

{
    function LiFxLoot::setup() {
      LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, dbInit, LiFxLoot);
      LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Dbchanges, LiFxLoot);
    }
    
    function LiFxLoot::dbInit() {
      dbi.Update("DROP TABLE IF EXISTS `lifx_loot`");
      %sqlTrigger = "CREATE TRIGGER `lifx_loot` BEFORE INSERT ON `movable_objects` FOR EACH ROW BEGIN SET SQL_SELECT_LIMIT =  CAST(FLOOR(RAND() * (2)+1) AS INT); INSERT INTO items SELECT NULL, new.RootContainerID, ItemObjectTypeID, @Quality :=FLOOR(RAND()*(MaxQuality-MinQuality+1)+MinQuality) AS Quality, FLOOR(RAND()*(MaxQuantity-MinQuantity+1)+MinQuantity) AS Quantity, @Durability := (SELECT FLOOR(50 + (1.5 * @Quality) * 100)) AS Durability, (@Durability) AS CreatedDurability, NULL FROM lifx_loot WHERE ContainerObjectTypeID = new.ObjectTypeID ORDER BY -LOG(RAND()) / Chance; SET SQL_SELECT_LIMIT = Default; END;\n";
      
      %sqlTable = "CREATE TABLE IF NOT EXISTS `lifx_loot` (\n";
      %sqlTable = %sqlTable @ "`ContainerObjectTypeID` INT(11) NOT NULL,\n";
      %sqlTable = %sqlTable @ "`ItemObjectTypeID` INT(11) NOT NULL,\n";
      %sqlTable = %sqlTable @ "`MinQuality` INT(11) NOT NULL,\n";
      %sqlTable = %sqlTable @ "`MaxQuality` INT(11) NOT NULL,\n";
      %sqlTable = %sqlTable @ "`MinQuantity` INT(11) NOT NULL,\n";
      %sqlTable = %sqlTable @ "`MaxQuantity` INT(11) NOT NULL,\n";
      %sqlTable = %sqlTable @ "`Chance` INT(11) NOT NULL\n";
      %sqlTable = %sqlTable @ ")\n";
      %sqlTable = %sqlTable @ "COLLATE='utf8mb3_unicode_ci'\n";
      %sqlTable = %sqlTable @ "ENGINE=InnoDB;\n";
      
      dbi.Update("DROP TRIGGER lifx_loot"); // Drop trigger to ensure we have the updated ones at  all times
      dbi.Update(%sqlTrigger); // Insert trigger
      dbi.Update(%sqlTable); // Create the table if it does not exist
    }
    function LiFxLoot::dbChanges() {
           ///////////////////////////////////////Loot Table /////////////////////////////////////////////
   // dbi.Update("INSERT IGNORE `lifx_loot` VALUES (ContainerID, ItemDropID, Min Quality, Max Quality, Min Quantity, Max Quantity, Chance)");
  //  dbi.Update("TRUNCATE TABLE `lifx_loot`");
    //BearKnool
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 282, 1, 100, 1, 3, 100)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 1699, 1, 100, 1, 3, 100)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 1344, 1, 100, 1, 3, 100)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 1060, 1, 100, 3, 6, 101)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 1059, 1, 100, 10, 15, 150)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 426, 1, 100, 1, 5, 150)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 1388, 1, 100, 1, 8, 101)"); // Bearhide
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 351, 40, 100, 1, 10, 250)"); // Bear Head
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 658, 60, 100, 10, 64, 450)"); // Fire Arrow
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 2462, 10, 80, 1, 1, 6000)"); // Bear AXE
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 44, 50, 100, 1, 1, 1000)"); // MALLET
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 990, 1, 100, 1, 12, 880)"); // NORMANN BREAD
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 1117, 1, 100, 1, 5, 630)"); // BEER
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 267, 1, 100, 3, 6, 850)"); // BRICK
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 281, 1, 100, 30, 250, 1200)"); // NAILS
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 287, 1, 100, 1, 2, 6000)"); // GATE MODULE
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2399, 416, 60, 100, 1, 10, 7500)"); // Vosk Lump


    //Witch
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 1635, 1, 100, 1, 3, 6000)"); // Apprentice Decorator kit
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 940, 1, 100, 1, 20, 5000)"); // Poisonous Preparation
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 972, 1, 100, 1, 20, 5000)"); // Peceno Veprevo Koleno
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 222, 1, 100, 1, 1, 5000)"); // Alchemical Glassware
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 305, 1, 100, 1, 1, 5000)"); // Herbilist outfit
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 1580, 1, 100, 1, 1, 5000)"); // Villeins Clothes
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 2461, 1, 100, 1, 1, 5000)"); // Witch Sickle
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 282, 1, 100, 1, 3, 5000)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 1699, 1, 100, 1, 3, 5000)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 1344, 1, 100, 1, 3, 5000)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 1060, 1, 100, 1, 99, 5000)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 1059, 1, 100, 1, 60, 5000)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 1388, 1, 100, 1, 8, 5000)"); // Bearhide
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 44, 50, 100, 1, 1, 5000)"); // MALLET
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 990, 1, 100, 1, 12, 5000)"); // NORMANN BREAD
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 1117, 1, 100, 1, 5, 5000)"); // BEER
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2362, 267, 1, 100, 1, 6, 5000)"); // BRICK
    //Hunter
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 282, 1, 100, 1, 3, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 342, 1, 100, 1, 150, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 1344, 1, 100, 1, 3, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 1060, 1, 100, 1, 15, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 1059, 1, 100, 1, 15, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 658, 60, 100, 1, 64, 97)"); // Fire Arrow
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 1578, 50, 100, 1, 1, 94)"); // Jarls Cloths
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 657, 1, 100, 1, 64, 22)"); // Broad Head Arrows
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 1117, 1, 100, 1, 5, 42)"); // BEER
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 267, 1, 100, 1, 6, 50)"); // BRICK
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 281, 1, 100, 1, 250, 27)"); // NAILS
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 326, 10, 100, 1, 10, 19)"); // REGION 14 HARDWOOD BOARD
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2360, 416, 60, 100, 1, 10, 7500)"); // Vosk Lump
    //Mole
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2361, 282, 1, 100, 1, 3, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2361, 1699, 1, 100, 1, 3, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2361, 1344, 1, 100, 1, 3, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2361, 1060, 1, 100, 10, 15, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2361, 1059, 1, 100, 6, 15, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2361, 658, 60, 100, 10, 64, 450)"); // Fire Arrow
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2361, 2465, 50, 100, 1, 1, 1000)"); // Mole PickAxe
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2361, 281, 1, 100, 30, 250, 1200)"); // NAILS
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2361, 287, 1, 100, 1, 2, 6000)"); // GATE MODULE
    //Hunter
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 282, 1, 100, 1, 3, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 1699, 1, 100, 1, 3, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 1344, 1, 100, 1, 3, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 1060, 1, 100, 10, 15, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 1059, 1, 100, 2, 15, 1)");
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 1495, 1, 100, 1, 1, 101)"); // Black Robe
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 351, 40, 100, 1, 10, 250)"); // Bear Head
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 658, 60, 100, 30, 64, 450)"); // Fire Arrow
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 281, 1, 100, 30, 450, 1200)"); // NAILS
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 39, 10, 100, 1, 1, 550)"); // Lamp
    dbi.Update("INSERT IGNORE `lifx_loot` VALUES (2359, 416, 60, 100, 1, 25, 3200)"); // Vosk Lump
    }
    function LiFxLoot::version() {
        return "0.0.1";
    }
};
activatePackage(LiFxLoot);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxLoot);