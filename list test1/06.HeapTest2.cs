using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] players, string[] callings)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        for (int i = 0; i < players.Length; i++)
        {
            dic.Add(players[i], i);                         //플레이어 i번째 ,값 i를 dic에 추가
        }

        foreach (string call in callings)                   //부르는 순서 call
        {
            int rank = dic[call];                           //부르는 순서로 랭크를 정함
            string overtake = players[rank - 1];            //쫒긴사람 = overtake

            players[rank - 1] = call;                       //쫒긴 사람은 부른사람이 됨        (player 배열에서)
            players[rank] = overtake;                       //부른사람은 쫓긴사람이됨          (player 배열에서)

            dic[call] = rank - 1;                           //   (dic에서)
            dic[overtake] = rank;                           //   (dic에서)
        }

        return players;
    } 
}