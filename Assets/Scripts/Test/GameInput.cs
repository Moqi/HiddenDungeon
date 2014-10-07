using UnityEngine;
using System.Collections;

public class GameInput : MonoBehaviour {
/*
	// ----------------------
	// Controller Variable 
	// ----------------------
	
	public	TouchController	ctrl;
	
	
	// ----------------------
	// Constants
	// ----------------------
	
	public const int STICK_STICK	= 0;
	public const int ZONE_FIRE	= 0;
	public const int ZONE_ACTION	= 1;
	
	
	// ----------------------
	// Update()
	// ----------------------
	
	void Update()
	{
		if (ctrl != null)
		{
			// ----------------------
			// Stick and Zone Variables
			// ----------------------
			
			TouchStick	stickStick	= ctrl.GetStick(STICK_STICK);
			TouchZone	fireZone	= ctrl.GetZone(ZONE_FIRE);
			TouchZone	actionZone	= ctrl.GetZone(ZONE_ACTION);
			
			
			// ----------------------
			// Input Handling Code
			// ----------------------
			
			// ----------------
			// Stick 'STICK'...
			// ----------------
			
			if (stickStick.Pressed())
			{
				Vector2	stickVec				= stickStick.GetVec();
				float	stickTilt			= stickStick.GetTilt();
				float	stickAngle			= stickStick.GetAngle();
				TouchStick.StickDir	stickDir	= stickStick.GetDigitalDir(true);
				Vector3	stickWorldVec		= stickStick.GetVec3d(false, 0);
				
				// Your code here.
			}
			
			// ----------------
			// Zone 'Fire'...
			// ----------------
			
			// Multi-Pressed...
			
			if (fireZone.MultiPressed())
			{
				float	fireMultiDur			= fireZone.GetMultiTouchDuration();
				Vector2	fireMultiPos			= fireZone.GetMultiPos();
				Vector2	fireMultiDragDelta		= fireZone.GetMultiDragDelta();
				Vector2	fireMultiRawDrawDelta	= fireZone.GetMultiDragDelta(true);
				
				
			}
			
			// Uni-touch pressed...
			
			if (fireZone.UniPressed())
			{
				float	fireUniDur				= fireZone.GetMultiTouchDuration();
				Vector2	fireUniPos				= fireZone.GetMultiPos();
				Vector2	fireUniDragDelta		= fireZone.GetMultiDragDelta();
				Vector2	fireUniRawDrawDelta	= fireZone.GetMultiDragDelta(true);
				
				
			}
			
			
			// Multi-Touch Just Released
			
			if (fireZone.JustMultiReleased())
			{
				Vector2	fireMultiRelStartPos	= fireZone.GetReleasedMultiStartPos();
				Vector2	fireMultiRelEndPos		= fireZone.GetReleasedMultiEndPos();
				int 	fireMultiRelStartBox	= TouchZone.GetBoxPortion(2, 2, fireZone.GetReleasedMultiStartPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				int 	fireMultiRelEndBox		= TouchZone.GetBoxPortion(2, 2, fireZone.GetReleasedMultiEndPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				
				Vector2	fireMultiRelDragVel	= fireZone.GetReleasedMultiDragVel();
				Vector2 fireMultiRelDragVec	= fireZone.GetReleasedMultiDragVec();
				
			}
			
			
			// Uni-Touch Just Released
			
			if (fireZone.JustUniReleased())
			{
				Vector2	fireUniRelStartPos	= fireZone.GetReleasedUniStartPos();
				Vector2	fireUniRelEndPos	= fireZone.GetReleasedUniEndPos();
				int 	fireUniRelStartBox	= TouchZone.GetBoxPortion(2, 2, fireZone.GetReleasedUniStartPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				int 	fireUniRelEndBox	= TouchZone.GetBoxPortion(2, 2, fireZone.GetReleasedUniEndPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				
				Vector2	fireUniRelDragVel	= fireZone.GetReleasedUniDragVel();
				Vector2 fireUniRelDragVec	= fireZone.GetReleasedUniDragVec();
				
				
			}
			
			
			// ----------------
			// Zone 'Action'...
			// ----------------
			
			// Multi-Pressed...
			
			if (actionZone.MultiPressed())
			{
				float	actionMultiDur			= actionZone.GetMultiTouchDuration();
				Vector2	actionMultiPos			= actionZone.GetMultiPos();
				Vector2	actionMultiDragDelta		= actionZone.GetMultiDragDelta();
				Vector2	actionMultiRawDrawDelta	= actionZone.GetMultiDragDelta(true);
				
				
			}
			
			// Uni-touch pressed...
			
			if (actionZone.UniPressed())
			{
				float	actionUniDur				= actionZone.GetMultiTouchDuration();
				Vector2	actionUniPos				= actionZone.GetMultiPos();
				Vector2	actionUniDragDelta		= actionZone.GetMultiDragDelta();
				Vector2	actionUniRawDrawDelta	= actionZone.GetMultiDragDelta(true);
				
				
			}
			
			
			// Multi-Touch Just Released
			
			if (actionZone.JustMultiReleased())
			{
				Vector2	actionMultiRelStartPos	= actionZone.GetReleasedMultiStartPos();
				Vector2	actionMultiRelEndPos		= actionZone.GetReleasedMultiEndPos();
				int 	actionMultiRelStartBox	= TouchZone.GetBoxPortion(2, 2, actionZone.GetReleasedMultiStartPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				int 	actionMultiRelEndBox		= TouchZone.GetBoxPortion(2, 2, actionZone.GetReleasedMultiEndPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				
				Vector2	actionMultiRelDragVel	= actionZone.GetReleasedMultiDragVel();
				Vector2 actionMultiRelDragVec	= actionZone.GetReleasedMultiDragVec();
				
			}
			
			
			// Uni-Touch Just Released
			
			if (actionZone.JustUniReleased())
			{
				Vector2	actionUniRelStartPos	= actionZone.GetReleasedUniStartPos();
				Vector2	actionUniRelEndPos	= actionZone.GetReleasedUniEndPos();
				int 	actionUniRelStartBox	= TouchZone.GetBoxPortion(2, 2, actionZone.GetReleasedUniStartPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				int 	actionUniRelEndBox	= TouchZone.GetBoxPortion(2, 2, actionZone.GetReleasedUniEndPos(TouchCoordSys.SCREEN_NORMALIZED)); 
				
				Vector2	actionUniRelDragVel	= actionZone.GetReleasedUniDragVel();
				Vector2 actionUniRelDragVec	= actionZone.GetReleasedUniDragVec();
				
				
			}
			
			
			
			
		}
	}
	*/
}
