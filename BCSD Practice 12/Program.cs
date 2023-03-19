using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Learning
{
	class Program
	{
		enum PlayerState { Idle, Move, Attack }
		static void Main()
		{
			PlayerState playerState = PlayerState.Idle;
			switch (playerState)
			{
				case PlayerState.Idle:
					Console.WriteLine(" 플레이어 상태 : 대기");
					break;
				case PlayerState.Move:
					Console.WriteLine("플레이어 상태 : 이동");
					break;
				case PlayerState.Attack:
					Console.WriteLine("플레이어 상태 : 공격");
					break;
			}
		}
	}
}