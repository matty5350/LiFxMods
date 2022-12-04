/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxChurch))
{
    new ScriptObject(LiFxChurch)
    {
    };
}

package LiFxChurch

{
    function LiFxChurch::setup() {
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, LiFxChurch);
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Dbchanges, LiFxChurch);
        
        // Register new objects
        LiFx::registerObjectsTypes(LiFxChurch::ObjectsTypesChurch(), LiFxChurch);

    }
    function LiFxChurch::version() {
        return "0.0.2";
    }

    function LiFxChurch::ObjectsTypesChurch() {
        return new ScriptObject(ObjectsTypesChurch : ObjectsTypes)
        {
            id = 2485; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "LiFx Church";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 1;
            IsPremium = 1;
            MaxContSize = 10000000;
            Length = 0; 
            MaxStackSize = 120;
            UnitWeight = 6000000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/art/2D/Recipies/Church.png";
            Description = "A Beautiful Church similar to one seen in godenland whilst fighting the great knool wars";
            BasePrice = 0;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

  function LiFxChurch::dbChanges() {
           ///////////////////////////////////////Recipe /////////////////////////////////////////////
    dbi.Update("INSERT IGNORE `recipe` VALUES (1087, 'LiFx Church', 'A Beautiful Church similar to one seen in godenland whilst fighting the great knool wars.', NULL, 62, 0, 2485, 10, 1, 0, 0, 'yolauncher/modpack/art/2D/Recipies/Church.png')");
   
     ///////////////////////////////////////Recipe Requirements /////////////////////////////////////////////

    dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, 1087, 233, 0, 10, 250, 0)"); // 250 x Logs
    dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, 1087, 269, 0, 80, 350, 0)"); // 350 x Shaped Stone
    dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, 1087, 272, 0, 10, 250, 0)"); // 250 x Glass
    dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, 1087, 271, 0, 80, 650, 0)"); // 650 x Shaped Granite
    dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, 1087, 326, 0, 10, 650, 0)"); // 650 x hardwood board

  }
};
activatePackage(LiFxChurch);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxChurch);