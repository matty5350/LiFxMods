/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxMolemod))
{
    new ScriptObject(LiFxMolemod)
    {
    };
}

package LiFxMolemod

{
    function LiFxMolemod::setup() {
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, LiFxMolemod);
        
        // Register new objects
        LiFx::registerObjectsTypes(LiFxMolemod::ObjectsTypesMoleCarcass(), LiFxMolemod);
        LiFx::registerObjectsTypes(LiFxMolemod::ObjectsTypesMole(), LiFxMolemod);

    }
    function LiFxMolemod::version() {
        return "0.0.3";
    }
    function LiFxMolemod::Datablock() {
        exec ("yolauncher/modpack/art/datablocks/animals/Moleknool.cs");
    }


    function LiFxMolemod::ObjectsTypesMoleCarcass() {
        return new ScriptObject(ObjectsTypesMoleCarcass : ObjectsTypes)
        {
            id = 2361; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Mole Carcass";
            ParentID = 624;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 10000000;
            Length = 10; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

        function LiFxMolemod::ObjectsTypesMole() {
        return new ScriptObject(ObjectsTypesMole: ObjectsTypes)
        {
            id = 2397; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Mole Knool";
            ParentID = 751;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 1000000;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 1;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
};
activatePackage(LiFxMolemod);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxMolemod);