/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxExtras))
{
    new ScriptObject(LiFxExtras)
    {
    };
}

package LiFxExtras

{
    function LiFxExtras::setup() {
     //   LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, LiFxExtras);
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, DbChanges, LiFxExtras);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, ContChanges, LiFxExtras);
        
        // Register new objects
    //    LiFx::registerObjectsTypes(LiFxExtras::ObjectsTypesLargeTanningtub(), LiFxExtras);

    }
    function LiFxExtras::version() {
        return "0.0.2";
    }

  function LiFxExtras::ContChanges() {
    
           ///////////////////////////////////////Recipe /////////////////////////////////////////////
    //  dbi.Update("INSERT IGNORE `recipe` VALUES (1092, 'Long House', 'A Beautiful house once home to the King of Godenland.', 32, 18, 90, 1232, 35, 1, 0, 0, 'yolauncher/modpack/art/2D/Recipies/Longhouse.png')");
     ///////////////////////////////////////Recipe Requirements /////////////////////////////////////////////

    //dbi.update("INSERT IGNORE INTO `objects_types` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 1000000 WHERE ID = 138");
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 300000 WHERE ID = 107");
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 500000 WHERE ID = 136");
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 25000000 WHERE ID = 682"); //camp fire increase container size
      dbi.Update("UPDATE `objects_types` SET  Length = 6 WHERE ID = 682"); //camp fire Length allows for more items storage
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 1000000 WHERE ID = 682"); //Kiln increase container size
      dbi.Update("UPDATE `objects_types` SET  MaxContSize = 200000 WHERE ID = 453"); //Forge and anvil increase container size

// changes for crafting storage

  }

  function LiFxExtras::DbChanges() {

//Perm Bans 

//  Desert 
dbi.update("INSERT INTO `account` (IsActive,IsGM,SteamID,VIPFLag) VALUES (0,0,76561198060145819,0) ON DUPLICATE KEY UPDATE IsActive = 0, IsGM = 0, SteamID = 76561198060145819, VIPFlag = 0;");
dbi.update("INSERT INTO `account` (IsActive,IsGM,SteamID,VIPFLag) VALUES (0,0,76561199232462040,0) ON DUPLICATE KEY UPDATE IsActive = 0, IsGM = 0, SteamID = 76561199232462040, VIPFlag = 0;");
// ムMathiasム☣
dbi.update("INSERT INTO `account` (IsActive,IsGM,SteamID,VIPFLag) VALUES (0,0,76561198843878768,0) ON DUPLICATE KEY UPDATE IsActive = 0, IsGM = 0, SteamID = 76561198843878768, VIPFlag = 0;");

//AutoVip
  
  }
};
activatePackage(LiFxExtras);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxExtras);