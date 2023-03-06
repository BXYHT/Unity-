//为笔试第二题答案

#include <iostream>
#include <queue>
using namespace std;

struct TreeNode
{
	int val;
	TreeNode *left, *right;
	TreeNode(int v):val(v),left(nullptr),right(nullptr){};
};

int main()
{
	TreeNode* head=new TreeNode(1);	//在这里认为我们已经获取这棵树的头结点，为head

	//测试数据
	head->left = new TreeNode(2); 
	head->right = new TreeNode(3); 
	head->left->left = new TreeNode(4);

	int curLevelCount = 1,nextLevelCount=0;
	TreeNode* ptr;
	queue<TreeNode*> nodes;
	nodes.push(head);

	//整体思路为BFS+记录每层节点数
	cout <<"请从上到下二叉树的最左侧节点依次为："<< head->val<<' ';
	while (!nodes.empty())
	{
		ptr = nodes.front();
		if (ptr->left!=nullptr)
		{
			nextLevelCount++;
			nodes.push(ptr->left);
		}
		if (ptr->right!=nullptr)
		{
			nextLevelCount++;
			nodes.push(ptr->right);
		}
		nodes.pop();
		curLevelCount--;
		if (curLevelCount == 0)
		{
			curLevelCount = nextLevelCount;
			nextLevelCount = 0;
			if(!nodes.empty())
			cout << nodes.front()->val<<' ';
		}
	}
	cout << endl;
	return 0;
}




