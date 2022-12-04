/**
* <author>Dorian Fendrel</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>PolankaMod</credits>
* <description>The Log Cart</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LogCart))
{
    new ScriptObject(LogCart)
    {
    };
}

package LogCart

{
    function LogCart::setup() {
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, LogCart);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, Dbchanges, LogCart);
        
        // Register new objects
        LiFx::registerObjectsTypes(LogCart::ObjectsTypesCart(), LogCart);
        LiFx::registerObjectsTypes(LogCart::ObjectsTypesHarnessedLogCart(), LogCart);

    }
    function LogCart::version() {
        return "0.0.1";
    }
        function LogCart::Datablock() {
        exec ("yolauncher/modpack/art/datablocks/Transport.cs");
    }

    function LogCart::ObjectsTypesCart() {
        return new ScriptObject(ObjectsTypesCart : ObjectsTypes)
        {
            id = 3016; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Log Cart";
            ParentID = 77;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 4000000;
            Length = 7; 
            MaxStackSize = 0;
            UnitWeight = 10000;
            BackgrndImage = 'art\\images\\universal';
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = 'art\\2D\\Objects\\trader_cart.png';
            Description = '';
            BasePrice = 135600;
            OwnerTimeout = 30;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
        function LogCart::ObjectsTypesHarnessedLogCart() {
        return new ScriptObject(ObjectsTypesHarnessedLogCart : ObjectsTypes)
        {
            id = 3018; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Harnessed Log Cart";
            ParentID = 77;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 4000000;
            Length = 7; 
            MaxStackSize = 0;
            UnitWeight = 10000;
            BackgrndImage = 'art\\images\\universal';
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = 'art\\2D\\Objects\\trader_cart.png';
            Description = '';
            BasePrice = 100;
            OwnerTimeout = 30;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

  function LogCart::dbChanges() {
           ///////////////////////////////////////Recipe /////////////////////////////////////////////
    dbi.Update("INSERT IGNORE `recipe` VALUES (1093,'LogCart','',36,8,90,3016,30,1,0,0, 'art\\2D\\Recipes\\horse_cart.png')");
   
     ///////////////////////////////////////Recipe Requirements /////////////////////////////////////////////

    dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, 1093, 235, 0, 20, 30, 0)"); // 30 x Boards
    dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, 1093, 255, 0, 15, 4, 0)"); // 4 x Wheels
	dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, 1093, 1131, 0, 15, 20, 0)"); // 20 x Metal Components
	dbi.Update("INSERT IGNORE `recipe_requirement` VALUES (NULL, 1093, 262, 0, 10, 10, 0)"); // 10 x Linen Rope
  }
};
activatePackage(LogCart);
LiFx::registerCallback($LiFx::hooks::mods, setup, LogCart);