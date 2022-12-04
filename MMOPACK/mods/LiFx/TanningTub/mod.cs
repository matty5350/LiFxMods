/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxLargeTanningtub))
{
    new ScriptObject(LiFxLargeTanningtub)
    {
    };
}

package LiFxLargeTanningtub

{
    function LiFxLargeTanningtub::setup() {
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, LiFxLargeTanningtub);
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Dbchanges, LiFxLargeTanningtub);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, ConChanges, LiFxLargeTanningtub);
        
        // Register new objects
        LiFx::registerObjectsTypes(LiFxLargeTanningtub::ObjectsTypesLargeTanningtub(), LiFxLargeTanningtub);
        LiFx::registerObjectsTypes(LiFxLargeTanningtub::ObjectsTypesLargeTanningtubB(), LiFxLargeTanningtub);

    }
    function LiFxLargeTanningtub::version() {
        return "0.0.1";
    }

    function LiFxLargeTanningtub::ObjectsTypesLargeTanningtub() {
        return new ScriptObject(ObjectsTypesLargeTanningtub : ObjectsTypes)
        {
            id = 2486; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "LiFx Large Tanning tub";
            ParentID = 64;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 1;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 2500000;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 10000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "art\2D\Objects\tanning_tub.png";
            Description = "why make 1 leather when I can make 10";
            BasePrice = 8400;
            OwnerTimeout = 150;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

        function LiFxLargeTanningtub::ObjectsTypesLargeTanningtubB() {
        return new ScriptObject(ObjectsTypesLargeTanningtubB : ObjectsTypes)
        {
            id = 3022; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "LiFx Large Tanning tub";
            ParentID = 1902; //1902
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 100000;
            Length = 6; 
            MaxStackSize = 10;
            UnitWeight = 100000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "art\2D\Objects\tanning_tub.png";
            Description = "why make 1 leather when I can make 10";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
  function LiFxLargeTanningtub::conChanges() {
      dbi.Update("INSERT IGNORE `objects_conversions` VALUES (NULL, 2486, 3022)");
      }
  function LiFxLargeTanningtub::dbChanges() {
           ///////////////////////////////////////Recipe /////////////////////////////////////////////
      dbi.Update("INSERT IGNORE `recipe` VALUES (1105, 'LiFx Large Tanning tub', 'A Beautiful Big Tanning tub similar to one seen in godenland whilst fighting the great knool wars.', 36, 8, 60, 2486, 10, 1, 0, 0, 'art/2D/Recipes/tanning_tub.png')");

     ///////////////////////////////////////Recipe Requirements /////////////////////////////////////////////

    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1105, 326, 0, 5, 25, 0)"); //hardwoodboard
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1105, 282, 0, 30, 15, 0)"); //Metalband
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1105, 262, 0, 30, 20, 1)"); //linenRope
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1105, 281, 0, 10, 250, 0)"); //nails
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1105, 36, 0, 10, 1, 0)"); //Saw 

      //CRAFTABLE ITEMS
           ///////////////////////////////////////Recipe /////////////////////////////////////////////
      dbi.Update("INSERT IGNORE `recipe` VALUES (1102, 'Thick Leather x 1', 'why make 1 leather when i can make 10 in a Large Tub?', 2486, 23, 60, 424, 10, 1, 0, 0, 'art/2D/Items/thick_leather.png')");
      dbi.Update("INSERT IGNORE `recipe` VALUES (1103, 'Thin Leather x 1', 'why make 1 leather when i can make 10 in a Large Tub?', 2486, 23, 60, 425, 10, 1, 0, 0, 'art/2D/Items/thin_leather.png')");
      dbi.Update("INSERT IGNORE `recipe` VALUES (1104, 'Flax fibers x 1', 'why make 20 flax fibers when i can make 200 in a Large Tub?', 2486, 23, 0, 377, 10, 20, 0, 0, 'art/2D/Items/flax_fibers.png')");

     ///////////////////////////////////////Recipe Requirements /////////////////////////////////////////////

    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
    //Thick Leather
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1102, 204, 0, 5, 4, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1102, 474, 0, 75, 1, 1)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1102, 2486, 0, 5, 20, 0)");
    //Thin Leather
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1103, 204, 0, 5, 4, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1103, 475, 0, 75, 1, 1)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1103, 2486, 0, 5, 20, 0)");
    //flax Fibers
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1104, 204, 0, 5, 4, 0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1104, 361, 0, 85, 10, 1)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, 1104, 2486, 0, 5, 20, 0)");

  }
};
activatePackage(LiFxLargeTanningtub);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxLargeTanningtub);