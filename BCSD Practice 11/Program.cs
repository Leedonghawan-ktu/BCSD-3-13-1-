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
		static void Main()
		{
			const int PlayerIdle = 0; 
			const int PlayerMove = 1; 
			const int PlayerAttack = 2; 
			int playerState = PlayerAttack; 
			switch (playerState)
			{
				case PlayerIdle:
					Console.WriteLine(" 플레이어 상태 : 대기"); 
				    break;
			    case PlayerMove:
					Console.WriteLine("플레이어 상태 : 이동"); 
				    break;
			    case PlayerAttack:
					Console.WriteLine("플레이어 상태 : 공격"); 
				    break; 
			}
		}
	}
}
