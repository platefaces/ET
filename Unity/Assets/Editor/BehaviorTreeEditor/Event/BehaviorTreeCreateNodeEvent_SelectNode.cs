﻿using Model;

namespace MyEditor
{
	[Event(EventIdType.BehaviorTreeCreateNode)]
	public class BehaviorTreeCreateNodeEvent_SelectNode: AEvent<NodeDesigner>
	{
		public override void Run(NodeDesigner dstNode)
		{
			BTEditorWindow.Instance.OnSelectNode(dstNode.NodeData, dstNode);
		}
	}
}