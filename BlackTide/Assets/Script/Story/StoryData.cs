using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class StoryData
{
    public static List<DialogSequence> dialogSequences = new List<DialogSequence>();

    public static void Init() {
        DialogSequence s1 = new DialogSequence(0, 1, GameState.SceneGame);
        s1.AddDialog(new Dialog("С��", "�š��ţ������ģ�������Ķ�����׼�����ˡ�", 3));
        s1.AddDialog(new Dialog("С��", "�϶����кܺõĳ��ֵġ�", 3));
        s1.AddDialog(new Dialog("С��", "��������ô���˻���绰���ʺ�������Ϣ��", 3));
        s1.AddDialog(new Dialog("С��", "�����������õģ���һ��ע�����塣", 3));
        dialogSequences.Add(s1);

        DialogSequence s2 = new DialogSequence(1, 2, GameState.SceneGame);
        s2.AddDialog(new Dialog("С��", "����ȵ�����һ�¡���", 4));
        s2.AddDialog(new Dialog("С��", "����֪������ʲô����", 4));
        s2.AddDialog(new Dialog("С��", "��������׻�ƴһƴ�¡���", 4));
        dialogSequences.Add(s2);

        DialogSequence s3 = new DialogSequence(2, 3, GameState.MiniGame);
        s3.AddDialog(new Dialog("С��", "��˾��ҵ����˳������Ⱥ���̶�������ߡ�"));
        dialogSequences.Add(s3);

        DialogSequence s4 = new DialogSequence(3, 4, GameState.MiniGame);
        s4.AddDialog(new Dialog("С��", "��ҵ��չ��ͷѸ�ͣ����Ӫ��������̨�ס�"));
        s4.AddDialog(new Dialog("С��", "��������˵Щ˭�����ŵĻ�����"));
        s4.AddDialog(new Dialog("С��", "���ҵ�����֧�Űɡ���"));
        dialogSequences.Add(s4);

        DialogSequence s5 = new DialogSequence(4, 5, GameState.MiniGame);
        s5.AddDialog(new Dialog("С��", "��ȥ��ͬ��ͬ����������"));
        dialogSequences.Add(s5);

        DialogSequence s6 = new DialogSequence(5, 6, GameState.MiniGame);
        s6.AddDialog(new Dialog("С��", "��ҵ��ȫ��ҵ������ͷ��λ��ռ��50%�����г��ݶ��"));
        s6.AddDialog(new Dialog("С��", "�ǣ���������ʲô��ϵ"));
        s6.AddDialog(new Dialog("С��", "������Ҫ��ҹ�Ӱ࡭��"));
        s6.AddDialog(new Dialog("С��", "��������Ҳ�Բ��¡�˯���š�"));
        s6.AddDialog(new Dialog("С��", "����治֪����ô�ˡ���"));
        s6.AddDialog(new Dialog("С��", "���Ǻȵ�����һ�°ɡ���"));
        dialogSequences.Add(s6);

        DialogSequence s7 = new DialogSequence(6, 7, GameState.MiniGame);
        s7.AddDialog(new Dialog("С��", "�þúþö��о����������ˡ���"));
        s7.AddDialog(new Dialog("С��", "ֻ�к����ʱ�������ӿ��û���ɵĿ��֡���"));
        s7.AddDialog(new Dialog("С��", "��֮ǰ���ǵξƲ�մ�ģ���������"));
        dialogSequences.Add(s7);

        DialogSequence s8 = new DialogSequence(7, 8, GameState.MiniGame);
        s8.AddDialog(new Dialog("С��", "�������ġ��ࡢ�ᣬ��������о�����"));
        s8.AddDialog(new Dialog("С��", "�ⲻ�����ҵ������𣬹���"));
        s8.AddDialog(new Dialog("С��", "����˵�ǺȾ�Ѱ����֣�����˵���ڳͷ��Լ�����"));
        dialogSequences.Add(s8);

        DialogSequence s9 = new DialogSequence(8, 9, GameState.SceneGame);
        s9.AddDialog(new Dialog("С��", "�ȵ��е��ͣ���ͷ�ˣ���������"));
        dialogSequences.Add(s9);

        DialogSequence s10 = new DialogSequence(9, 10, GameState.SceneGame);
        s10.AddDialog(new Dialog("С��", "���ˣ��Ȱ����˵Ĺ��ˣ���һ�²桭��"));
        dialogSequences.Add(s10);

        DialogSequence s11 = new DialogSequence(10, 11, GameState.MiniGame);
        s11.AddDialog(new Dialog("С��", "����ӿ�����ˡ�����Ҫ��������ʱ���С���"));
        s11.AddDialog(new Dialog("С��", "��ѹ��ȥ����"));
        dialogSequences.Add(s11);

        DialogSequence s12 = new DialogSequence(11, 12, GameState.MiniGame);
        s12.AddDialog(new Dialog("С��", "(���ۣ����ǡ���ѹ��ס������"));
        dialogSequences.Add(s12);




        //�±�

        DialogSequence p1 = new DialogSequence(20, 21, GameState.SceneGame);
        p1.AddDialog(new Dialog("С��", "�������ƶ�ԨԴ���۸塷����"));
        p1.AddDialog(new Dialog("С��", "��Ҳ����ʷѧԺ������ ?"));
        dialogSequences.Add(p1);

        DialogSequence p2 = new DialogSequence(20, 21, GameState.SceneGame);
        p2.AddDialog(new Dialog("С��", "��û��û�С�����������ת���ģ�����ʷ����Ȥ��������"));
        p2.AddDialog(new Dialog("С��", "�Ҿ��Ǹо�û�������"));
        p2.AddDialog(new Dialog("С��", "���ǵ�һ���ڰ�����������һ������ʷ���ء�"));
        p2.AddDialog(new Dialog("С��", "(ǳЦ)�ҽ�С�գ���ʷѧԺ���ġ�"));
        p2.AddDialog(new Dialog("С��", "������ʷϵ����? ������Ǹ�רҵ��һ��?"));
        p2.AddDialog(new Dialog("С��", "�Ƕ��ǹ�ȥ���¶��ˡ��Ժ��Ҷཻ��Ŷ��"));
        p2.AddDialog(new Dialog("С��", "���Ҳ��ң��ҳԺ����ֻ��Ƚ��У������ͷ���ˣ�����������һ����ѽ��"));
        p2.AddDialog(new Dialog("С��", "��ǫ�ˡ�"));
        p2.AddDialog(new Dialog("С��", "����˵���������������ת�����ģ��������Ҫ����רҵ�Ρ�"));
        p2.AddDialog(new Dialog("С��", "���С��ż���Ҫ���� ?"));
        p2.AddDialog(new Dialog("С��", "�������ˡ���"));
        dialogSequences.Add(p2);
    }
}

