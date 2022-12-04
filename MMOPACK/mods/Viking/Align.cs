$AlignmentUpdateDelta = 20;
$AlignmentUpdateMinutes = 60;

function PlayerList::customAlignmentUpdate( %this ) {
   foreach(%player in %this) %player.changeAlignment($AlignmentUpdateDelta);
   %this.schedule($AlignmentUpdateMinutes * 60000, customAlignmentUpdate);
}

PlayerList.customAlignmentUpdate();