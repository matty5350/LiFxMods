/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxKnoolWeapon))
{
    new ScriptObject(LiFxKnoolWeapon)
    {
    };
}

package LiFxKnoolWeapon

{
    function LiFxKnoolWeapon::setup() {
        LiFx::registerCallback($LiFx::hooks::onPostInitCallbacks, Datablock, LiFxKnoolWeapon);
        
        // Register new objects
        LiFx::registerObjectsTypes(LiFxKnoolWeapon::ObjectsTypesWitchSickle(), LiFxKnoolWeapon);
        LiFx::registerObjectsTypes(LiFxKnoolWeapon::ObjectsTypesBearAxe(), LiFxKnoolWeapon);
        LiFx::registerObjectsTypes(LiFxKnoolWeapon::ObjectsTypesChieftainSword(), LiFxKnoolWeapon);
        LiFx::registerObjectsTypes(LiFxKnoolWeapon::ObjectsTypesHunterAxe(), LiFxKnoolWeapon);
        LiFx::registerObjectsTypes(LiFxKnoolWeapon::ObjectsTypesMolePickaxe(), LiFxKnoolWeapon);
        LiFx::registerObjectsTypes(LiFxKnoolWeapon::ObjectsTypesHunterBow(), LiFxKnoolWeapon);

    }
    function LiFxKnoolWeapon::ObjectsTypesWitchSickle() {
        return new ScriptObject(ObjectsTypesWitchSickle : ObjectsTypes)
        {
            id = 2461; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Witch Sickle";
            ParentID = 1031;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 1;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 3; 
            MaxStackSize = 1;
            UnitWeight = 1500;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/art/2D/Items/NativeWeapons/Witch_Sickle.png";
            Description = "A Weapon of the knools, Liberated from one whom was slayed.";
            BasePrice = 3100;
            OwnerTimeout = "NULL";
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
        function LiFxKnoolWeapon::ObjectsTypesBearAxe() {
        return new ScriptObject(ObjectsTypesBearAxe : ObjectsTypes)
        {
            id = 2462; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Bear Axe";
            ParentID = 58;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 4; 
            MaxStackSize = 1;
            UnitWeight = 3500;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/art/2D/Items/NativeWeapons/bearaxe.png";
            Description = "A Weapon of the knools, Liberated from one whom was slayed.";
            BasePrice = 7900;
            OwnerTimeout = "NULL";
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
        function LiFxKnoolWeapon::ObjectsTypesChieftainSword() {
        return new ScriptObject(ObjectsTypesChieftainSword : ObjectsTypes)
        {
            id = 2463; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Chieftain Sword";
            ParentID = 57;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 4; 
            MaxStackSize = 1;
            UnitWeight = 5000;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/art/2D/Items/NativeWeapons/chieftainsword.png";
            Description = "A Weapon of the knools, Liberated from one whom was slayed.";
            BasePrice = 0;
            OwnerTimeout = 0;
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
        function LiFxKnoolWeapon::ObjectsTypesHunterAxe() {
        return new ScriptObject(ObjectsTypesHunterAxe : ObjectsTypes)
        {
            id = 2464; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Hunter Axe";
            ParentID = 34;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 1;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 3; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/art/2D/Items/NativeWeapons/hunteraxe.png";
            Description = "A Weapon of the knools, Liberated from one whom was slayed.";
            BasePrice = 3100;
            OwnerTimeout = "NULL";
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
        function LiFxKnoolWeapon::ObjectsTypesMolePickaxe() {
        return new ScriptObject(ObjectsTypesMolePickaxe : ObjectsTypes)
        {
            id = 2465; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Mole Pickaxe";
            ParentID = 35;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 1;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 3; 
            MaxStackSize = 1;
            UnitWeight = 1600;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/art/2D/Items/NativeWeapons/Molepickaxe.png";
            Description = "A Weapon of the knools, Liberated from one whom was slayed.";
            BasePrice = 3600;
            OwnerTimeout = "NULL";
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }
        function LiFxKnoolWeapon::ObjectsTypesHunterBow() {
        return new ScriptObject(ObjectsTypesHunterBow : ObjectsTypes)
        {
            id = 2466; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Hunter Bow";
            ParentID = 196;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 3; 
            MaxStackSize = 1;
            UnitWeight = 3000;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/art/2D/Items/NativeWeapons/hunterbow.png";
            Description = "A Bow of the knools, Liberated from one whom was slayed.";
            BasePrice = 20000;
            OwnerTimeout = "NULL";
            AllowExportFromRed = 1;
            AllowExportFromGreen = 1;
        };
    }

        function LiFxKnoolWeapon::version() {
        return "0.0.1";
    }
    function LiFxKnoolWeapon::Datablock() {
        exec ("yolauncher/modpack/art/datablocks/Weapons/datablock.cs");
    }
};
activatePackage(LiFxKnoolWeapon);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxKnoolWeapon);