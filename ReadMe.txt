
Unity前端岗位笔试题

1. 本题有两个小题，请不要使用第三方库实现（如DoTween等）。
1)	实现 move(GameObjct gameObject, Vector3 begin, Vector3 end, float time, bool pingpong){ } 使 gameObject 在 time 秒内，从 begin 移动到 end，若 pingpong 为 true，则在结束时 使 gameObject 在 time 秒内从 end 移动到 begin，如此往复。
2)	在上题基础上实现 easeIn easeOut easeInOut 动画效果。

见Move.cs 和 Move与曲线动画效果演示.mkv


2. 请从上到下依次打印出一颗二叉树的最左侧节点。

见FindLeftNode.cpp


3.请详述使用过或编写过的UI框架，画出结构图或者类图。

使用过：Unity-UGUI Unreal-HUD、Widget
Unity-UGUI的架构图见：实习项目《太阴》UGUI结构图：Canvas
