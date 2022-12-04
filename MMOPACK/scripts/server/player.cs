datablock PlayerData(DefaultPlayerData)
{
   id = 3;
   sprintTime = 2;        // default is 2
   sprintCooldown = 2;    // default is 2
   className = Armor;
   shapeFile = "art/models/3d/mobiles/characters/male.dts";
   cameraMaxDist = 2.5;
   cameraMinDist = 0.8;
   cameraMaxDistWarStance = 2.5 + 1.2;
   cameraMinDistWarStance = 0.5;
   buildCameraMaxDist = 100;
   buildCameraMinDist = 5;
   buildScopeSize = 10;
   computeCRC = 0;
   warstanceCamAngTheta = 0.4;
   peacestanceCamAngTheta = 0;
   canObserve = 1;
   cmdCategory = "Clients";
   cameraDefaultFov = 75;
   cameraMinFov = 5;
   cameraMaxFov = 120;
   debrisShapeName = "art/shapes/actors/common/debris_player.dts";
   debris = playerDebris;
   aiAvoidThis = 1;
   minLookAngle = -1.2;
   maxLookAngle = 1.2;
   minLookAngleVolley = -1.2;
   maxLookAngleVolley = 1.2;
   maxFreelookAngle = 3;
   lookupdown_animation_angle_min = -1.396;
   lookupdown_animation_angle_max = 1.396;
   mass = 100;
   drag = 1.3;
   maxdrag = 0.4;
   density = 1.1;
   maxDamage = 100;
   maxEnergy = 60;
   repairRate = 0.33;
   energyPerDamagePoint = 75;
   rechargeRate = 0.256;
   runForce = 4320;
   rotSpeedFirstPersonStay = 0.22;
   rotSpeedFirstPersonMove = 0.12;
   rotSpeedThirdPersonStay = 0.22;
   rotSpeedThirdPersonMove = 0.12;
   rotSpeedRotationAnim = 0.32;
   headVThreadMaxSpeedStay = 0.04;
   headVThreadMaxSpeedMove = 0.03;
   mountedRotationAnimationMaxSpeedStay = 0.04;
   mountedRotationAnimationMaxSpeedMove = 0.03;
   maxForwardSpeed = 4;
   maxBackwardSpeed = 3;
   maxSideSpeed = 3;
   maxRuningSpeed = 8;
   maxWarForwardSpeed = 4;      // default is 4
   maxWarBackwardSpeed = 2.5;   // default is 2.5
   maxWarSideSpeed = 4.5;       // default is 4.5
   maxWarRuningSpeed = 8;       // default is 8
   crouchForce = 405;
   maxCrouchForwardSpeed = 4;
   maxCrouchBackwardSpeed = 2;
   maxCrouchSideSpeed = 2;
   equipDrownCoeff = 0.35;
   waterStaminaRate = 0.08;
   O2consumption = 4;
   O2refresh = 20;
   HPdrowning = 5;
   maxUnderwaterForwardSpeed = 4;
   maxUnderwaterBackwardSpeed = 3;
   maxUnderwaterSideSpeed = 3;
   skillSwimmingDistance = 100;
   jumpForce = 900;
   pounceForce = 900;
   jumpDelay = 15;
   airControl = 0.01;
   recoverDelay = 9;
   recoverRunForceScale = 1.2;
   minImpactSpeed = 15;
   impactGroundSpeed = 20;
   speedDamageScale = 1.6;
   boundingBox = "1.5 1 3.5";
   crouchBoundingBox = "1.5 1 3";
   swimBoundingBox = "1 2 2";
   standardRaycastBox = "4.244 4.747 4.246";
   mountingRaycastBox = "4.691 11.666 5.425";
   pickupRadius = 1;
   runSurfaceAngle = 75; //defeault 46
   jumpSurfaceAngle = 80;
   maxStepHeight = 0.5;
   minJumpSpeed = 20;
   maxJumpSpeed = 30;
   knockedDownTicks = 1;
   horizMaxSpeed = 68;
   horizResistSpeed = 33;
   horizResistFactor = 0.35;
   upMaxSpeed = 80;
   upResistSpeed = 25;
   upResistFactor = 0.3;
   groundImpactMinSpeed = 100;
   observeParameters = "0.5 4.5 4.5";
   mainWeapon = SwordWeapon;
   class = "armor";
};
datablock PlayerData(PlayerMaleData : DefaultPlayerData)
{
   id = 400;
   shapeFile = "art/models/3d/mobiles/characters/male.dts";
};
datablock PlayerData(PlayerFemaleData : DefaultPlayerData)
{
   id = 401;
   shapeFile = "art/models/3d/mobiles/characters/female.dts";
   imageScale = "1 1 1";
   horseScale = "0.892 0.892 0.892";
   shapeScale = "0.892 0.892 0.892";
};
datablock CameraData(Observer)
{
   id = 139;
   mode = "Observer";
   useEyePoint = 1;
   firstPersonOnly = 1;
};
datablock PathCameraData(PathCamData)
{
   id = 356;
   useEyePoint = 1;
   firstPersonOnly = 1;
};

$CorpseTimeoutValue = 45 * 1000;
$PlayerDeathAnim::TorsoFrontFallForward = 1;
$PlayerDeathAnim::TorsoFrontFallBack = 2;
$PlayerDeathAnim::TorsoBackFallForward = 3;
$PlayerDeathAnim::TorsoLeftSpinDeath = 4;
$PlayerDeathAnim::TorsoRightSpinDeath = 5;
$PlayerDeathAnim::LegsLeftGimp = 6;
$PlayerDeathAnim::LegsRightGimp = 7;
$PlayerDeathAnim::TorsoBackFallForward = 8;
$PlayerDeathAnim::HeadFrontDirect = 9;
$PlayerDeathAnim::HeadBackFallForward = 10;
$PlayerDeathAnim::ExplosionBlowBack = 11;
function Armor::onAdd(%this, %obj)
{
    %obj.mountVehicle = 1;
    %obj.setRepairRate(0);
}
function Armor::onRemove(%this, %obj)
{
    if (%obj.client.Player == %obj)
    {
        %obj.client.Player = 0;
    }
}
function Armor::onNewDataBlock(%this, %obj)
{
    hack(%this, %obj, %this.shapeScale);
    if (!(%this.shapeScale $= ""))
    {
        %obj.setScale(%this.shapeScale);
    }
    else
    {
        %obj.setScale("1 1 1");
    }
}
function Armor::doDismount(%this, %obj, %forced, %kickedOff)
{
    %vehicle = %obj.getObjectMount();
    if (!%obj.isMounted() && !isObject(%vehicle))
    {
        error(%obj.isMounted(), %vehicle);
        return 0;
    }
    %rot = getWords(%vehicle.getTransform(), 3, 6);
    %oldPos = VectorAdd(%vehicle.getPosition(), "0 0 1");
    if (%kickedOff)
    {
        %vec = "0 0 1";
        %vec2[%i] = MatrixMulVector(%vehicle.getTransform(), %vec[%i]);
        %pos = VectorAdd(%oldPos, VectorScale(%vec2[%i], 2));
    }
    else
    {
        %vec[0] = "-1 0 0";
        %vec[1] = "1 0 0";
        %vec[2] = "0 -1.5 0";
        %vec[3] = "0 1.5 0";
        %vec[4] = "0 0 1";
        %impulseVec = "0 0 0";
        %numAttempts = 5;
        %success = -1;
        %i = 0;
        while (%i < %numAttempts)
        {
            %vec2[%i] = MatrixMulVector(%vehicle.getTransform(), %vec[%i]);
            %pos = VectorAdd(%oldPos, VectorScale(%vec2[%i], 2));
            if (isDebugBuild())
            {
                %obj.getControllingClient().cmSendClientMessage(1356, %vec[%i] SPC "|" SPC %vec2[%i] SPC "|" SPC VectorSub(%pos, %vehicle.getPosition()));
            }
            if ((%success == -1) && %obj.checkDismountPoint(%oldPos, %pos))
            {
                %success = %i;
                %impulseVec = %vec[%i];
                break;
            }
            %i = %i + 1;
        }
        if (%forced && (%success == -1))
        {
            %pos = %oldPos;
        }
    }
    %obj.mountVehicle = 0;
    %obj.schedule(4000, "mountVehicles", 1);
    %obj.unmount();
    %obj.setTransform(%pos SPC %rot);
    %vel = %obj.getVelocity();
    %vec = VectorDot(%vel, VectorNormalize(%vel));
    if (%vec > 50)
    {
        %scale = 50 / %vec;
        %obj.setVelocity(VectorScale(%vel, %scale));
    }
    return 1;
}
function Armor::onCollision(%this, %obj, %col)
{
    if (!isObject(%col) && (%obj.getState() $= "Dead"))
    {
        return;
    }
    if (%col.getClassName() $= "Item")
    {
        %obj.pickup(%col);
        return;
    }
    if (%col.getClassName() $= "Horse")
    {
        %col.processCollisionWithPlayer(%obj);
    }
    return;
    echo("col.getClassName()" @ %col.getClassName() @ " col.getType() " @ %col.getType());
    if (%col.getType() & 2048)
    {
        %db = %col.getDataBlock();
        echo("db.getClassName() " @ %db.getClassName() @ " && " @ %obj.mountVehicle @ " && " @ %obj.getState() @ " && " @ %col.mountable);
        if (%obj.mountVehicle && (%obj.getState() $= "Move"))
        {
            ServerConnection.setFirstPerson(0);
            %mount = %col.getMountNodeObject(0);
            if (%mount)
            {
                return;
            }
            %node = 0;
            %col.mountObject(%obj, %node);
        }
    }
}
function Armor::onImpact(%this, %obj, %collidedObject, %vec, %vecLen)
{
    %obj.damage(0, VectorAdd(%obj.getPosition(), %vec), %vecLen * %this.speedDamageScale, "Impact");
}
function Armor::damage(%this, %obj, %sourceObject, %position, %damage, %damageType)
{
    echo("Armor::damage()");
    if (!isObject(%obj) && (%obj.getState() $= "Dead"))
    {
        return;
    }
    %obj.applyDamage(%damage, %obj);
    %location = "Body";
    %client = %obj.client;
    %sourceClient = %sourceObject ? %sourceObject : 0;
    if ((%obj.getState() $= "Dead") && isObject(%client))
    {
        %client.onDeath(%sourceObject, %sourceClient, %damageType, %location);
    }
}
function Armor::onDamage(%this, %obj, %delta)
{
}
function Armor::onLeaveMissionArea(%this, %obj)
{
    %obj.client.onLeaveMissionArea();
}
function Armor::onEnterMissionArea(%this, %obj)
{
    %obj.client.onEnterMissionArea();
}
function Armor::onEnterLiquid(%this, %obj, %coverage, %type)
{
}
function Armor::onLeaveLiquid(%this, %obj, %type)
{
}
function Armor::onTrigger(%this, %obj, %triggerNum, %val)
{
}
function Player::kill(%this, %damageType)
{
    %this.damage(0, %this.getPosition(), 10000, %damageType);
}
function Player::mountVehicles(%this, %bool)
{
    %this.mountVehicle = %bool;
}
function Player::isPilot(%this)
{
    %vehicle = %this.getObjectMount();
    if (%vehicle)
    {
        if (%vehicle.getMountNodeObject(0) == %this)
        {
            return 1;
        }
    }
    return 0;
}
function Player::playDeathAnimation(%this)
{
    if (isObject(%this.client))
    {
        if (%this.client.deathIdx = %this.client.deathIdx + 1 > 11)
        {
            %this.client.deathIdx = 1;
        }
        %this.setActionThread("Death" @ %this.client.deathIdx);
    }
    else
    {
        %rand = getRandom(1, 11);
        %this.setActionThread("Death" @ %rand);
    }
}
function Player::playCelAnimation(%this, %anim)
{
    if (!(%this.getState() $= "Dead"))
    {
        %this.setActionThread("cel" @ %anim);
    }
}
function Player::playDeathCry(%this)
{
    %this.playAudio(0, DeathCrySound);
}
function Player::playPain(%this)
{
    %this.playAudio(0, PainCrySound);
}
function Player::use(%player, %data)
{
    if (%player.isPilot())
    {
        return 0;
    }
    Parent::use(%player, %data);
}
function serverCmdenterVehicle(%client)
{
    if (!%client.isGM())
    {
        return;
    }
    %player = %client.getControlObject();
    if (%player.getClassName() $= "Player")
    {
        %eyeVec = %player.getEyeVector();
        %startPos = %player.getEyePoint();
        %endPos = VectorAdd(%startPos, VectorScale(%eyeVec, 6));
        %target = containerRayCast(%startPos, %endPos, 1 << 17);
        if (%target)
        {
            %mount = %target.getMountNodeObject(0);
            if (%mount && (%mount.getClassName() $= "AIPlayer"))
            {
                commandToServer('carUnmountObj', %mount);
            }
            if (%player.mountVehicle && (%player.getState() $= "Move"))
            {
                %node = 0;
                %target.mountObject(%player, %node);
            }
        }
        else
        {
            %player.disableCollision();
            %target = containerRayCast(%startPos, %endPos, 1 << 13);
            %player.enableCollision();
            if (%target && (%target.getClassName() $= "StaticShapeWithDoor"))
            {
                %target.toggleDoor();
                echo("toggle door!");
            }
        }
    }
}