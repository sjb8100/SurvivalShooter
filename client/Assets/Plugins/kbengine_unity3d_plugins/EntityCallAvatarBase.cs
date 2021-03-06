/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Avatar.def
	public class EntityBaseEntityCall_AvatarBase : EntityCall
	{

		public EntityBaseEntityCall_AvatarBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

	}

	public class EntityCellEntityCall_AvatarBase : EntityCall
	{

		public EntityCellEntityCall_AvatarBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

		public void reqFrameChange(ENTITY_DATA arg1)
		{
			Bundle pBundle = newCall("reqFrameChange", 0);
			if(pBundle == null)
				return;

			((DATATYPE_ENTITY_DATA)EntityDef.id2datatypes[22]).addToStreamEx(bundle, arg1);
			sendCall(null);
		}

		public void reqNetworkDelay(Int32 arg1)
		{
			Bundle pBundle = newCall("reqNetworkDelay", 0);
			if(pBundle == null)
				return;

			bundle.writeInt32(arg1);
			sendCall(null);
		}

	}
	}
