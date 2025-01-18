using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class StoryData
{
    public static List<DialogSequence> dialogSequences = new List<DialogSequence>();

    public static void Init()
    {
        DialogSequence s1 = new DialogSequence(0, 1, GameState.SceneGame);
        s1.AddDialog(new Dialog("С��", "�š��ţ������ģ�������Ķ�����׼�����ˡ�", 1));
        s1.AddDialog(new Dialog("С��", "�϶����кܺõĳ��ֵġ�", 1));
        s1.AddDialog(new Dialog("С��", "��������ô���˻���绰���ʺ�������Ϣ��", 1));
        s1.AddDialog(new Dialog("С��", "�����������õģ���һ��ע�����塣", 1));
        dialogSequences.Add(s1);

        DialogSequence s2 = new DialogSequence(1, 2, GameState.SceneGame);
        s2.AddDialog(new Dialog("С��", "����ȵ�����һ�¡���"));
        s2.AddDialog(new Dialog("С��", "����֪������ʲô����"));
        s2.AddDialog(new Dialog("С��", "��������׻�ƴһƴ�¡���"));
        dialogSequences.Add(s2);

        DialogSequence s3 = new DialogSequence(2, 3, GameState.SceneGame);
        s3.AddDialog(new Dialog("С��", "��˾��ҵ����˳������Ⱥ���̶�������ߡ�"));
        dialogSequences.Add(s3);

        DialogSequence s4 = new DialogSequence(3, 4, GameState.SceneGame);
        s4.AddDialog(new Dialog("С��", "��ҵ��չ��ͷѸ�ͣ����Ӫ��������̨�ס�"));
        s4.AddDialog(new Dialog("С��", "��������˵Щ˭�����ŵĻ�����"));
        s4.AddDialog(new Dialog("С��", "���ҵ�����֧�Űɡ���"));
        dialogSequences.Add(s4);

        DialogSequence s5 = new DialogSequence(4, 5, GameState.SceneGame);
        s5.AddDialog(new Dialog("С��", "��ȥ��ͬ��ͬ����������"));
        dialogSequences.Add(s5);

        DialogSequence s6 = new DialogSequence(5, 6, GameState.SceneGame);
        s6.AddDialog(new Dialog("С��", "��ҵ��ȫ��ҵ������ͷ��λ��ռ��50%�����г��ݶ��"));
        s6.AddDialog(new Dialog("С��", "�ǣ���������ʲô��ϵ"));
        s6.AddDialog(new Dialog("С��", "������Ҫ��ҹ�Ӱ࡭��"));
        s6.AddDialog(new Dialog("С��", "��������Ҳ�Բ��¡�˯���š�"));
        s6.AddDialog(new Dialog("С��", "����治֪����ô�ˡ���"));
        s6.AddDialog(new Dialog("С��", "���Ǻȵ�����һ�°ɡ��������ϣ��ı���������"));
        dialogSequences.Add(s6);

        DialogSequence s7 = new DialogSequence(6, 7, GameState.SceneGame);
        s7.AddDialog(new Dialog("С��", "�þúþö��о����������ˡ���"));
        s7.AddDialog(new Dialog("С��", "ֻ�к����ʱ�������ӿ��û���ɵĿ��֡���"));
        s7.AddDialog(new Dialog("С��", "��֮ǰ���ǵξƲ�մ�ģ���������"));
        dialogSequences.Add(s7);

        DialogSequence s8 = new DialogSequence(7, 8, GameState.SceneGame);
        s8.AddDialog(new Dialog("С��", "�������ġ��ࡢ�ᣬ��������о�����"));
        s8.AddDialog(new Dialog("С��", "�ⲻ�����ҵ������𣬹���"));
        s8.AddDialog(new Dialog("С��", "����˵�ǺȾ�Ѱ����֣�����˵���ڳͷ��Լ�����"));
        dialogSequences.Add(s8);

        DialogSequence s9 = new DialogSequence(8, 9, GameState.SceneGame);
        s9.AddDialog(new Dialog("С��", "�ȵ��е��ͣ���ͷ�ˣ���������"));
        dialogSequences.Add(s9);

        DialogSequence s10 = new DialogSequence(9, 10, GameState.LastSceneGame);
        s10.AddDialog(new Dialog("С��", "���ˣ��Ȱ����˵Ĺ��ˣ���һ�²桭��"));
        dialogSequences.Add(s10);

        DialogSequence s11 = new DialogSequence(10, 11, GameState.MiniGame);
        s11.AddDialog(new Dialog("С��", "����ӿ�����ˡ�����Ҫ��������ʱ���С���"));
        s11.AddDialog(new Dialog("С��", "��ѹ��ȥ����"));
        dialogSequences.Add(s11);

        DialogSequence s12 = new DialogSequence(11, 12, GameState.MiniGame);
        s12.AddDialog(new Dialog("С��", "(���ǡ���ѹ��ס������"));
        dialogSequences.Add(s12);


        //���µ��ϱ����

        DialogSequence g1 = new DialogSequence(12, 13, GameState.SceneGame);
        g1.AddDialog(new Dialog("С��", "�Ҹе��ұ�һֱ����ȥ����Ҳ��֪����ȥ�����", 7));
        g1.AddDialog(new Dialog("С��", "�ޱߵĺڰ�������ͣ����׹����", 7));
        g1.AddDialog(new Dialog("С��", "�ҡ��������ʳ�����", 8));
        g1.AddDialog(new Dialog("С��", "�Բ��𡭡��Ҳ�������", 9));
        g1.AddDialog(new Dialog("������", "û��ϵ�����ɣ�һ�л�������ġ�", 10));
        g1.AddDialog(new Dialog("������", "�㻹���𣿷����ɣ���һ������ɡ�", 10));
        dialogSequences.Add(g1);

        DialogSequence g2 = new DialogSequence(13, 14, GameState.MiniGame);
        g2.AddDialog(new Dialog("������", "��������ɡ���"));
        dialogSequences.Add(g2);

        DialogSequence g3 = new DialogSequence(14, 15, GameState.SceneGame);
        g3.AddDialog(new Dialog("������", "���ܺúò��ã���Ҫ�Ҷ�Ŷ��"));
        g3.AddDialog(new Dialog("С��", "�á���"));
        dialogSequences.Add(g3);


        DialogSequence g4 = new DialogSequence(15, 16, GameState.SceneGame);
        g4.AddDialog(new Dialog("С��", "лл�㡭��", 15));
        g4.AddDialog(new Dialog("������", "��Ǹ���ղ������������ѹ��Ļ��䡣����������һ������������ĺ����ܡ���", 15));
        g4.AddDialog(new Dialog("������", "�������ĵ������������ȥ�����飬����", 15));
        g4.AddDialog(new Dialog("С��", "�õġ���лл����", 15));
        dialogSequences.Add(g4);

        //�ϱ�
        DialogSequence f1 = new DialogSequence(200, 16, GameState.LastSceneGame);
        f1.AddDialog(new Dialog("С��", "�Բ��𡭡������Ҳ��á�"));
        f1.AddDialog(new Dialog("С��", "�Բ��𣬶����ҵĴ�"));
        f1.AddDialog(new Dialog("С��", "�Ҳ��ò���������"));
        f1.AddDialog(new Dialog("С��", "�Բ��𣬶����ҡ���"));
        f1.AddDialog(new Dialog("��ѯʦ", "���£���Ŀ־���ƭ�㡣"));
        f1.AddDialog(new Dialog("��ѯʦ", "����ȥ�ˡ����ǿ���ǿ����ʵ�ܴ�����������һ����"));
        f1.AddDialog(new Dialog("��ѯʦ", "���Ѿ�����Щ�ڰ���ʱ�����߹����ˣ����Ѿ�սʤ�����ˡ�"));
        f1.AddDialog(new Dialog("��ѯʦ", "�㻹�ǵ���"));
        f1.AddDialog(new Dialog("��ѯʦ", "�������ǣ������Լ���"));
        dialogSequences.Add(f1);

        DialogSequence f2 = new DialogSequence(201, 16, GameState.LastSceneGame);
        f2.AddDialog(new Dialog("��ѯʦ", "���Ѿ�սʤ�����ˣ�ֻ������μ��䱻�������µ�ʹ���ɱ��ˣ��������Щ���ǰɡ�"));
        dialogSequences.Add(f2);

        DialogSequence f3 = new DialogSequence(202, 16, GameState.LastSceneGame);
        f3.AddDialog(new Dialog("��ѯʦ", "�㻹�ǵ��㵱ʱ��ôսʤ��Щʹ�����"));
        dialogSequences.Add(f3);

        DialogSequence f4 = new DialogSequence(203, 16, GameState.LastSceneGame);
        f4.AddDialog(new Dialog("��ѯʦ", "�Ѹ��������飬�������㡣"));
        dialogSequences.Add(f4);

        //���¹���

        DialogSequence t1 = new DialogSequence(16, 17, GameState.Dialog);
        t1.AddDialog(new Dialog("��ѯʦ", "�����Һ������㡣"));
        t1.AddDialog(new Dialog("��ѯʦ", "��ô����������������"));
        t1.AddDialog(new Dialog("��ѯʦ", "һ���˳�������ô�࣬һ����һ�εĵ���������������"));
        t1.AddDialog(new Dialog("С��", "лл����"));
        t1.AddDialog(new Dialog("С��", "���ڹ�ȥ�������ܶ�ʹ�ࡣ"));
        t1.AddDialog(new Dialog("С��", "����ѵ�ʱ�̣��Ҷ��˺ܶ�����ѧ�Ƶ��顣"));
        t1.AddDialog(new Dialog("С��", "������ѧ������ҡ�"));
        dialogSequences.Add(t1);

        DialogSequence t2 = new DialogSequence(17, 18, GameState.Dialog);
        t2.AddDialog(new Dialog("С��", "����"));
        t2.AddDialog(new Dialog("С��", "���ԡ����ҵ�ȷ�������Ĺػ�������ȥ������ѧ�硣"));
        t2.AddDialog(new Dialog("С��", "���Ҽǵ����������ʹ�࣬����ܶ���û�����Ĺػ���"));
        t2.AddDialog(new Dialog("С��", "���ڴ�����ʵ�����Ĺػ����ǰ���"));
        t2.AddDialog(new Dialog("С��", "���ԣ���������ô���ޱߵ�ʹ���а������ġ���"));
        t2.AddDialog(new Dialog("��ѯʦ", "�ؼ��������Լ�����û�����ܴ����������һ�С�"));
        dialogSequences.Add(t2);

        DialogSequence t3 = new DialogSequence(18, 20, GameState.SceneGame);
        t3.AddDialog(new Dialog("С��", "һ�����и��ˣ������Һܶమ�������߳���һ�С�"));
        t3.AddDialog(new Dialog("С��", "�Һ���ǵ������ҵ����壬�����ҵ�֧�֡���"));
        t3.AddDialog(new Dialog("С��", "������˭�����׳�ʲô���ӡ���"));
        t3.AddDialog(new Dialog("С��", "�Ҽǲ�����"));
        t3.AddDialog(new Dialog("��ѯʦ", "�ǲ���Ͳ�Ҫ�����ˡ�����һ��ʲô���鶼Ҫ�������ġ���"));
        t3.AddDialog(new Dialog("С��", "�����Ҹе������Һ���Ҫ����"));
        t3.AddDialog(new Dialog("��ѯʦ", "��ʱ����������ǰɡ���Ҳ�����������ʹ���"));
        t3.AddDialog(new Dialog("С��", "�����������ļǵ����Ĵ��ڣ���һĻĻ����"));
        dialogSequences.Add(t3);


        //�±�
        DialogSequence p1 = new DialogSequence(20, 21, GameState.SceneGame);
        p1.AddDialog(new Dialog("С��", "�������ƶ�ԨԴ���۸塷����"));
        p1.AddDialog(new Dialog("С��", "��Ҳ����ʷϵ������ ?"));
        dialogSequences.Add(p1);

        DialogSequence p2 = new DialogSequence(21, 22, GameState.SceneGame);
        p2.AddDialog(new Dialog("С��", "��û��û�С�����������ת���ģ�����ʷ����Ȥ��������"));
        p2.AddDialog(new Dialog("С��", "�Ҿ��Ǹо�û�������"));
        p2.AddDialog(new Dialog("С��", "���ǵ�һ��������ʵ�������������һ������ʷ���ء�"));
        p2.AddDialog(new Dialog("С��", "(ǳЦ)�ҽ�С�գ���ʷϵ���ġ�"));
        p2.AddDialog(new Dialog("С��", "������ʷϵ����? ������Ǹ�רҵ��һ��?"));
        p2.AddDialog(new Dialog("С��", "�Ƕ��ǹ�ȥ���¶��ˡ��Ժ��Ҷཻ��Ŷ��"));
        p2.AddDialog(new Dialog("С��", "���Ҳ��ҡ���˵��������ʵ��������ǰ������ѧ��Ȧ����Ȼ�������������ľ�Ӣ����Ҫ��������ѧϰѽ��"));
        p2.AddDialog(new Dialog("С��", "��ǫ�ˡ�"));
        p2.AddDialog(new Dialog("С��", "����˵���������������ת�����ģ��������Ҫ����רҵ�Ρ�"));
        p2.AddDialog(new Dialog("С��", "���С��ż���Ҫ���� ?"));
        p2.AddDialog(new Dialog("С��", "�������ˡ���"));
        dialogSequences.Add(p2);

        DialogSequence p3 = new DialogSequence(22, 23, GameState.MiniGame);
        p3.AddDialog(new Dialog("С��", "��ͦ�µģ�����̫����...."));
        p3.AddDialog(new Dialog("С��", "û��ϵ�ģ�����������ε���ʶ����ĺܳ�ǰ�ˡ�"));
        p3.AddDialog(new Dialog("С��", "����㲻�����Ļ�����֮ǰ�����������׵����Σ�����һЩ�ʼǣ����Թ���ο���"));
        dialogSequences.Add(p3);

        DialogSequence p4 = new DialogSequence(23, 24, GameState.SceneGame);
        p4.AddDialog(new Dialog("С��", "��̫лл�ˣ��������Ư������"));
        p4.AddDialog(new Dialog("С��", "������Ŷ���Ժ�ཻ����"));
        p4.AddDialog(new Dialog("С��", "���š���"));
        dialogSequences.Add(p4);

        DialogSequence p5 = new DialogSequence(24, 25, GameState.SceneGame);
        p5.AddDialog(new Dialog("С��", "����������������������ͦ�з����"));
        p5.AddDialog(new Dialog("С��", "���Ĵ���ʱ�򣬽�������ͦ�������ġ�"));
        p5.AddDialog(new Dialog("С��", "(��ͷǳЦ)����ʺϴ�������"));
        p5.AddDialog(new Dialog("С��", "������лл��ҲҪлл����ҵ��������֮ǰ����������ۡ�"));
        dialogSequences.Add(p5);

        DialogSequence p6 = new DialogSequence(25, 26, GameState.Dialog);
        p6.AddDialog(new Dialog("С��", "����������ϴ�������ˣ����������档"));
        p6.AddDialog(new Dialog("С��", "������ġ���"));
        p6.AddDialog(new Dialog("С��", "��Ȼ������ϴ�ˡ�"));
        p6.AddDialog(new Dialog("С��", "��Ҳû��ô���������"));
        dialogSequences.Add(p6);

        DialogSequence p7 = new DialogSequence(26, 27, GameState.SceneGame);
        p7.AddDialog(new Dialog("С��", "��������"));
        p7.AddDialog(new Dialog("С��", "�����Ǹ���лл�㡣"));
        p7.AddDialog(new Dialog("С��", "��ôͻȻ˵�����"));
        p7.AddDialog(new Dialog("С��", "лл��Ը�Ⱨ���������"));
        p7.AddDialog(new Dialog("С��", "��Ҳû��˵����ô���ദ�"));
        p7.AddDialog(new Dialog("С��", "����ô����������ô��������˭���᲻�Ҹ��㽻���İɡ���"));
        dialogSequences.Add(p7);


        DialogSequence p8 = new DialogSequence(27, 28, GameState.MiniGame);
        p8.AddDialog(new Dialog("С��", "�������Ҳ����Ǹ���˼����"));
        p8.AddDialog(new Dialog("С��", "(����Ц)�����ţ���֪����û�ж���"));
        p8.AddDialog(new Dialog("С��", "(��ͷ�ȿ���)�������ϻ��˺ܶ࣬�������������档"));
        p8.AddDialog(new Dialog("С��", "��������������ܼ򵥡���"));
        p8.AddDialog(new Dialog("С��", "����ͷ���������˵���£�����ѧУ�����Ż��"));
        p8.AddDialog(new Dialog("С��", "�������ݻ�����? ���Ǿ��ź�ȱ����Ա��"));
        p8.AddDialog(new Dialog("С��", "���Ͼ���һ��Ϸ��"));
        p8.AddDialog(new Dialog("С��", "��ô�õı��������������������ʡ�"));
        p8.AddDialog(new Dialog("С��", "�������ð���"));
        p8.AddDialog(new Dialog("С��", "������ص�ͼ�������ţ��������Ľ������ˡ�"));
        dialogSequences.Add(p8);

        DialogSequence p8_2 = new DialogSequence(28, 29, GameState.SceneGame);
        p8_2.AddDialog(new Dialog("С��", "�������Ч�ˡ�"));
        p8_2.AddDialog(new Dialog("С��", "(ǳЦ)��ʱ����"));
        dialogSequences.Add(p8_2);
 
        DialogSequence p9 = new DialogSequence(29, 30, GameState.SceneGame);
        p9.AddDialog(new Dialog("С��", "û�뵽��Ū����ô��"));
        p9.AddDialog(new Dialog("С��", "����ͷ����ȭ�������ϣ��Ҳ��ǰ����������Ҹɻ�ġ���"));
        p9.AddDialog(new Dialog("С��", "�ҵ�ʱֻ�Ǿ��������������ɫ��"));
        p9.AddDialog(new Dialog("С��", "�ҵ�Ȼ֪��������ô����ô�롣"));
        p9.AddDialog(new Dialog("С��", "����Ȼ��ͷ���Ҳ����鷳�㡭��"));
        p9.AddDialog(new Dialog("С��", "��Щ�����Լ����Ըɺá�"));
        p9.AddDialog(new Dialog("С��", "����˵��"));
        p9.AddDialog(new Dialog("С��", "������Ը��æ�ģ����Ƕ��������¸ɺã�����"));
        p9.AddDialog(new Dialog("С��", "�㲻��Ҫ��һ�ж������Լ����ϡ�"));
        p9.AddDialog(new Dialog("С��", "�����ڣ�����һ����ԣ��ò��á�"));
        p9.AddDialog(new Dialog("С��", "Ϸ��������Ĭ���޼����Ů���ǣ�Ϸ������Ҳһ�����һ�кò��á�"));
        p9.AddDialog(new Dialog("С��", "����"));
        p9.AddDialog(new Dialog("С��", "����Ⱦơ��Ҵ��ˡ����ҵ�һ��������"));
        p9.AddDialog(new Dialog("С��", "����Ȼ���ԡ�"));
        dialogSequences.Add(p9);

        DialogSequence p10 = new DialogSequence(30, 31, GameState.SceneGame);
        p10.AddDialog(new Dialog("С��", "�����Բ���Բ���", 28));
        p10.AddDialog(new Dialog("С��", "���������Լ����Ըɺõġ���", 28));
        p10.AddDialog(new Dialog("С��", "����ô˵����", 28));
        p10.AddDialog(new Dialog("С��", "����ͷ����ϰ����һ�ж���һ���ˡ�", 29));
        p10.AddDialog(new Dialog("С��", "��С������һֱ���Լ����¡�", 29));
        p10.AddDialog(new Dialog("С��", "���趼æ��Ҳ������ѧ�������", 29));
        p10.AddDialog(new Dialog("С��", "�Ҽǵ�ʮ�����꣬�ְ�����æ������һֱû�л�����", 29));
        p10.AddDialog(new Dialog("С��", "����", 29));
        p10.AddDialog(new Dialog("С��", "�����֣�������ʳָ������������𡭡�", 30));
        dialogSequences.Add(p10);

        DialogSequence p11 = new DialogSequence(31, 32, GameState.Dialog);
        p11.AddDialog(new Dialog("С��", "�Ұ��Լ�����˴�⬣������˿�����", 31));
        p11.AddDialog(new Dialog("С��", "��Ϊ�Ҳ��롭��", 31));
        p11.AddDialog(new Dialog("С��", "���㣬��ܿɿ�����", 31));
        p11.AddDialog(new Dialog("С��", "����", 31));
        p11.AddDialog(new Dialog("С��", "�㻹�ǵ��Ҹ��������Ʊ��", 31));
        p11.AddDialog(new Dialog("С��", "���������š�", 32));
        p11.AddDialog(new Dialog("С��", "��ɡ���ڱη��꣬õ�������ף�̫������", 33));
        p11.AddDialog(new Dialog("С��", "�����Ҳ����ĵ׵�Ը����", 33));
        p11.AddDialog(new Dialog("С��", "�ҽ�С�գ����ҵ�������û��̫����", 33));
        p11.AddDialog(new Dialog("С��", "��֪��Ϊʲô��Ҫ�Ų�خ�ġ��ճ�����", 33));
        p11.AddDialog(new Dialog("С��", "��֪��Ϊʲô��Ҫ�ݳ°�¶��", 33));
        p11.AddDialog(new Dialog("С��", "�Һ���һ�����������޷��԰Σ����Ƕ��ڴ���̫������ҫ���ǡ���", 33));
        dialogSequences.Add(p11);

        DialogSequence p12 = new DialogSequence(32, 33, GameState.SceneGame);
        p12.AddDialog(new Dialog("С��", "�Һȶ��ˣ�����Ļ�������Ķ԰ɡ�", 34));
        p12.AddDialog(new Dialog("С��", "��Ȼ���һ�����������ܡ�", 34));
        p12.AddDialog(new Dialog("С��", "����һ��̨�ʰɡ���Ȼ���ȥ˯����", 34));
        p12.AddDialog(new Dialog("С��", "̫���������ˣ��ڰ����ں��档", 34));
        p12.AddDialog(new Dialog("С��", "����", 34));
        p12.AddDialog(new Dialog("С��", "��̫���������ǵģ�����Ҫ˯�ˡ�", 34));
        p12.AddDialog(new Dialog("С��", "������ʱ�����������ܺڡ�", 34));
        p12.AddDialog(new Dialog("С��", "���ߵ���ǰ��Ļ�������", 34));
        p12.AddDialog(new Dialog("С��", "����������һ���ӡ�", 34));
        dialogSequences.Add(p12);


        DialogSequence p13 = new DialogSequence(33, 34, GameState.Dialog);
        p13.AddDialog(new Dialog("С��", "����"));
        p13.AddDialog(new Dialog("С��", "����"));
        p13.AddDialog(new Dialog("С��", "������㡭��"));
        p13.AddDialog(new Dialog("С��", "�⻰������˵����֪��һ�����׵�����Ա�ж�������"));
        p13.AddDialog(new Dialog("С��", "�Ҳ���˵�������"));
        p13.AddDialog(new Dialog("С��", "����"));
        p13.AddDialog(new Dialog("С��", "лл�㣬�������������ʱ��Ը��ӵ�������ǵ��ҡ���"));
        dialogSequences.Add(p13);

        DialogSequence p14 = new DialogSequence(34, 35, GameState.Dialog);
        p14.AddDialog(new Dialog("С��", "����о����庺��ѧ�����Ϸ���ѧ�����ģ��������ڴ�ѧ������������"));
        p14.AddDialog(new Dialog("С��", "��һ��һ�ڻ㱨�ξ�һ�����ˣ���Ժ��˵�����о���ˮƽ��"));
        p14.AddDialog(new Dialog("С��", "��ʷϵ��һ����������ʵ��໹�ǵ�һ����"));
        p14.AddDialog(new Dialog("С��", "˭��ϲ���㰡��"));
        p14.AddDialog(new Dialog("С��", "���ҡ���"));
        p14.AddDialog(new Dialog("С��", "�Ҳ�֪��Ϊʲô��ѧ������Щ��������"));
        p14.AddDialog(new Dialog("С��", "�Ҳ�ֹһ�α������۲�̤ʵ�������ף��ҵ�һ�в��Ҷ��Ǿ�����ȡ��"));
        p14.AddDialog(new Dialog("С��", "�Һ�ί������"));
        p14.AddDialog(new Dialog("С��", "�Ҿ����Լ������������ı����䣬û����֪������ô�򿪣�ֻ��һ���ȥ�ԡ�"));
        p14.AddDialog(new Dialog("С��", "�Ҳ�֪����ô�����ܿ�ʼ̤̤ʵʵ�ķܶ�����֪��ʲôʱ�����ȡ��һЩ�ɼ���"));
        p14.AddDialog(new Dialog("С��", "�ڴ�֮ǰ�Ҿ���һ��ʧ���ߣ�һ�����������Ļ��ӡ�"));
        p14.AddDialog(new Dialog("С��", "���ҵ�����������������ȫû�����壬��Ϊʲô��ȥ��һ���������ǰ;��õ��к����ء�"));
        dialogSequences.Add(p14);

        DialogSequence p15 = new DialogSequence(35, 36, GameState.SceneGame);
        p15.AddDialog(new Dialog("С��", "������ô˵�Լ���"));
        p15.AddDialog(new Dialog("С��", "��ʵ˵����Ҳ�����˺ܶ�������"));
        p15.AddDialog(new Dialog("С��", "���ң�ֻ�����Լ������ġ�"));
        p15.AddDialog(new Dialog("С��", "�����������ᣬ�ж���֮��������֮˼�롣"));
        p15.AddDialog(new Dialog("С��", "�Ҿ�����ȱһ����Ե�����Ժ�һ���������Ϊ��"));
        p15.AddDialog(new Dialog("С��", "����Ҫ���ǡ���"));
        p15.AddDialog(new Dialog("С��", "��Ҳ���ҵ�������"));
        dialogSequences.Add(p15);

        //�ǿնԻ�
        //С��1
        DialogSequence sky1 = new DialogSequence(101, 36, GameState.LastSceneGame);
        sky1.AddDialog(new Dialog("С��", "��˵�˺ܶ���ˣ�ѧ�Ŀ������Լ���ѡ���Ҿ���ϲ����"));
        sky1.AddDialog(new Dialog("�绰", "��ϲ�������������ɼ�����"));
        sky1.AddDialog(new Dialog("�绰", "����רҵ��û����ҵ�������������������ҵ��ô�죿"));
        sky1.AddDialog(new Dialog("�绰", "�úõ��������ӣ���ѧ�����Խ����ѧ�����"));
        sky1.AddDialog(new Dialog("�绰", "������������Щʲô������"));
        sky1.AddDialog(new Dialog("�绰", "�㻹�����д����ˣ�ϲ����ϲ�������ð���������ʲô���ˣ�"));
        sky1.AddDialog(new Dialog("�绰", "�Һ�������ҵ�����һ���ӣ���Ҳ�ز�������ɳ������ܸ�ɶ������һ���ӣ�"));
        dialogSequences.Add(sky1);

        //��Ⱥ��2
        DialogSequence sky2 = new DialogSequence(102, 36, GameState.LastSceneGame);
        sky2.AddDialog(new Dialog("��Ⱥ1", "�ϣ�����ģ��������̸���������黳�ˡ�"));
        sky2.AddDialog(new Dialog("��Ⱥ1", "�������²���һ�㣬��֪�������裿"));
        sky2.AddDialog(new Dialog("��Ⱥ2", "���ǣ����첻��ʵ�ʵģ�Ҳ�������Լ�ɶ����"));
        sky2.AddDialog(new Dialog("��Ⱥ2", "�����й��򣬻������ȥ�μӼ���ʵϰ�����ܵ㾭�飬�Ժ��ҹ���Ҳ���׵㡣"));
        sky2.AddDialog(new Dialog("��Ⱥ3", "�����Լ����£�����ɶ��ڡ�"));
        sky2.AddDialog(new Dialog("��Ⱥ3", "��������������Ŭ�����������뵱��ڡ�"));
        sky2.AddDialog(new Dialog("��Ⱥ3", "���ǻ�ã�����ɶ��ͬ��ġ�"));
        dialogSequences.Add(sky2);

        //С�գ�4
        DialogSequence sky3 = new DialogSequence(104, 36, GameState.LastSceneGame);
        sky3.AddDialog(new Dialog("С��", "���ǲ�Ҫ��˵�ˣ��Ҹ����ദ����ô�����Լ����жϡ�"));
        sky3.AddDialog(new Dialog("С��", "�����������ᡢ�ж�����˼�롣"));
        sky3.AddDialog(new Dialog("С��", "��ֻ��û�ҵ��Լ��Ľ�����ѡ�"));
        sky3.AddDialog(new Dialog("С��", "��Ҫ�������˺���"));
        dialogSequences.Add(sky3);

        //��С�� & ��Ⱥ��1+2 = 3
        DialogSequence sky4 = new DialogSequence(103, 36, GameState.LastSceneGame);
        sky4.AddDialog(new Dialog("��Ⱥ", "�ϣ��ѵ��������ΰ���"));
        sky4.AddDialog(new Dialog("С��", "����"));
        sky4.AddDialog(new Dialog("��Ⱥ", "������������ν���������ֲ�����"));
        sky4.AddDialog(new Dialog("С��", "���ǲ����á�������ÿ�������û��������"));
        sky4.AddDialog(new Dialog("С��", "��ν�����ް�Ķ�������£���������񽻹��ˡ�"));
        sky4.AddDialog(new Dialog("С��", "Ϊʲôÿ����ֻ���ı��н�ѧ�𰡡�"));
        sky4.AddDialog(new Dialog("С��", "�����ô����Ǯ��Ϊʲô��ѧ�����ƣ�������ӵ�������"));
        sky4.AddDialog(new Dialog("��Ⱥ", "���ֿ�ʼװ���ˡ�"));
        sky4.AddDialog(new Dialog("��Ⱥ", "������ɫ�����ʡ�"));
        sky4.AddDialog(new Dialog("��Ⱥ", "���㱣�и��㽱ѧ����Ҫ��Ҫ��"));
        sky4.AddDialog(new Dialog("��Ⱥ", "װʲô�������⡭��"));
        sky4.AddDialog(new Dialog("��Ⱥ", "��Ҫ��ȥ������ô�õ�רҵ�һ��������ϻ���"));
        dialogSequences.Add(sky4);

        //��С�� & ��Ⱥ�� 4+2 = 6
        DialogSequence sky5 = new DialogSequence(106, 36, GameState.LastSceneGame);
        sky5.AddDialog(new Dialog("��Ⱥ", "���Ѿ��õ�������ѧ�����ⲹ¼�ʸ��˰���"));
        sky5.AddDialog(new Dialog("��Ⱥ", "Ϊʲô��һ־Ը�����ϣ��㲻��ȥ������ѧ��"));
        sky5.AddDialog(new Dialog("��Ⱥ", "˵������ȥ�ˡ�"));
        sky5.AddDialog(new Dialog("С��", "���Ѿ��ͱ�У����ʦ˵���ˣ�½��ʦ���Һܺã��Ҳ���ʧԼ��"));
        sky5.AddDialog(new Dialog("��Ⱥ", "�Ѳ��ɾ�����ѧ��Ҫ�����㻹��ȥ��"));
        sky5.AddDialog(new Dialog("С��", "�ҵ�Ȼ��ȥ�����ѵ����ý�������"));
        sky5.AddDialog(new Dialog("��Ⱥ", "����"));
        sky5.AddDialog(new Dialog("��Ⱥ", "�������ҡ�"));
        sky5.AddDialog(new Dialog("��Ⱥ", "�����ǰ;������������һ�Ĳ�ֵ��"));
        dialogSequences.Add(sky5);

        //��С��&��Ⱥ&С�ա� 4+1+2 = 7
        DialogSequence sky6 = new DialogSequence(107, 36, GameState.LastSceneGame);
        sky6.AddDialog(new Dialog("��Ⱥ1", "��Զ��ɣ������������ˡ�"));
        sky6.AddDialog(new Dialog("��Ⱥ1", "�˼Ҷ��ǲ�м��ͬ�����ۣ�Ҫ������绽���ˡ�"));
        sky6.AddDialog(new Dialog("��Ⱥ2", "����Ҫ�д���ţһ���Ҳ�����ڻ��������"));
        dialogSequences.Add(sky6);

        //��С�� & С�ա� 4+1 = 5
        DialogSequence sky7 = new DialogSequence(105, 36, GameState.LastSceneGame);
        sky7.AddDialog(new Dialog("С��", "����������ʲô��ϵ����"));
        sky7.AddDialog(new Dialog("С��", "���Ѿ�����ѽ��"));
        dialogSequences.Add(sky7);


        DialogSequence p16 = new DialogSequence(36, 37, GameState.Dialog);
        p16.AddDialog(new Dialog("С��", "лл��ѡ���ҡ�", 20));
        p16.AddDialog(new Dialog("С��", "����ô˵��", 20));
        p16.AddDialog(new Dialog("С��", "�����ǻ�����ꡣ", 20));
        p16.AddDialog(new Dialog("С��", "������Һܶࡣ", 20));
        p16.AddDialog(new Dialog("С��", "��֮ǰ����һ�����������Ҷ��˴��ķ���", 20));
        p16.AddDialog(new Dialog("С��", "��������֮����Ը����һ������", 20));
        p16.AddDialog(new Dialog("С��", "���е�ʱ���ҵİ����θ����ң�", 20));
        p16.AddDialog(new Dialog("С��", "�������а���һ�����ơ���", 20));
        p16.AddDialog(new Dialog("С��", "��һֱ������仰��", 20));
        p16.AddDialog(new Dialog("С��", "�������Ͳ������ˡ���", 20));
        p16.AddDialog(new Dialog("С��", "�������㡣", 20));
        p16.AddDialog(new Dialog("С��", "��Ϊ�㣬��Ը�������ˡ�", 20));
        p16.AddDialog(new Dialog("С��", "������ɫ������", 20));
        p16.AddDialog(new Dialog("С��", "�¹����������ϣ������ɫ��ȹ�ӽ����ӳ�������׵Ļ�ɴ��", 20));
        p16.AddDialog(new Dialog("С��", "�㴩��׵Ļ�ɴ�϶��ر�����", 20));
        dialogSequences.Add(p16);

        DialogSequence p17 = new DialogSequence(37, 38, GameState.SceneGame);
        p17.AddDialog(new Dialog("С��", "����ô�ˣ��㻹����", 21));
        p17.AddDialog(new Dialog("С��", "�ǲ�����̫ðʧ�ˣ��Բ���Բ����Ҳ����������㲻���˵ġ�", 21));
        p17.AddDialog(new Dialog("С��", "��������̫�����ˡ�", 21));
        p17.AddDialog(new Dialog("С��", "���Ҳ����������", 21));
        p17.AddDialog(new Dialog("С��", "�ã����һ�¡�", 21));
        dialogSequences.Add(p17);


        DialogSequence p18 = new DialogSequence(38, 39, GameState.SceneGame);
        p18.AddDialog(new Dialog("С��", "�´��Ҹ������"));
        p18.AddDialog(new Dialog("С��", "������һ��Ϊ�����ҿ϶�Ҳ�ᾭ���Ҹ�������ġ�"));
        dialogSequences.Add(p18);

        DialogSequence p19 = new DialogSequence(39, 45, GameState.SceneGame);
        p19.AddDialog(new Dialog("С��", "������"));
        p19.AddDialog(new Dialog("С��", "������������������������"));
        dialogSequences.Add(p19);


        //��ʱ�նԻ�
        DialogSequence ts1 = new DialogSequence(40, 46, GameState.LastSceneGame);
        ts1.AddDialog(new DialogSplit("С��", "��һ��ѧ�ھ���ô�����˰���",
           "С��", "���Ǻþ�û�е����ദ���ˡ���"));
        ts1.AddDialog(new DialogSplit("С��", "��ʰ��ʰ������������ЩҪ���ؼҰɡ�",
            "С��", "��Щ�£�����������ġ���"));
        dialogSequences.Add(ts1);

        //��Ƭ
        DialogSequence ts2 = new DialogSequence(41, 46, GameState.LastSceneGame);
        ts2.AddDialog(new DialogSplit("С��", "�������п��ɼ������Ǹ����ϣ��ҿ���ȫ���һ�����Ҽǵ��Ǹ�ʱ���һ��ܼᶨ��Ҫ���ྩ��ѧҽѧԺ�أ�",
           "С��", "�������п���ľ۲��ա�"));
        ts2.AddDialog(new DialogSplit("С��", "��ҽ�������������������β����˰�������ʲô���β����˸�ΰ������鰡��",
            "С��", "�Ǹ�ʱ���������������ѡ�Ƶ����顣"));
        ts2.AddDialog(new DialogSplit("С��", "��ʱ��үү���̾���˵��Ҫ��ҽ����үү�ɿ����ˣ�˵���˽Ӱ��ˡ�",
           "С��", "�Ҹ�ĸ����ҽ��������������Ҳ����ҽ����"));
        ts2.AddDialog(new DialogSplit("С��", "��ϧ�ҷֲ���û�����ٴ�ҽѧ���ҵķ���������ȥ���������ɣ����Ǹ��������ûʲô����������",
            "С��", "���������ҷ��ֱ��������˽������Ҹ����������Ҹ���"));
        ts2.AddDialog(new DialogSplit("С��", "�ֲ�������β����ˣ�ֻ�ܷ���һ�´�Ⱦ��ʲô�ģ������Ļ���ʲô���µĴ�Ⱦ������",
           "С��", "�Ҿ��������ѧ�úܺã�ѧ�Ļ��ϧ������"));
        ts2.AddDialog(new DialogSplit("С��", "���߻�������ǹ�ȥʽ�ˣ��컨��������ˡ�",
            "С��", "���ְָ���˵��������������ġ�"));
        ts2.AddDialog(new DialogSplit("С��", "����",
           "С��", "����"));
        ts2.AddDialog(new DialogSplit("С��", "�����û��ʵ��Сʱ������밡��",
            "С��", "����������ѧ����ʷ��"));
        dialogSequences.Add(ts2);

        //�α�
        DialogSequence ts3 = new DialogSequence(42, 46, GameState.LastSceneGame);
        ts3.AddDialog(new DialogSplit("С��", "��α���������Ҫ���İ���",
           "С��", "˵��ģ�����ʷ�Һ��Ҹ������������صĿ�Խʱ�գ��͹�ȥһ�������ȹ��̵������ӵ��"));
        ts3.AddDialog(new DialogSplit("С��", "��Ȼ˵����ѧУ����ѧ�ǳ������ĺã�ȫ�����㶥��ġ�",
            "С��", "����������Խ��Խ��ã�ˡ�"));
        ts3.AddDialog(new DialogSplit("С��", "���о�ȷʵ����ô���氡��������˼ά��Ϸ�����о���̫�ܴ����ҡ�",
           "С��", "��Խ�ǽ���Ѫ����һ�g������Խ����ʵ�е��Լ��е�������"));
        ts3.AddDialog(new DialogSplit("С��", "�����еĴ�ѧӦ�����д�ʦ�������롢�����顢���¶ȵġ�",
            "С��", "�Ҷ���ʵ������Ŀ���������ţ�ȴ�Թž���Ŀݹ�����ӯ�������ѵ����Ǳ�ĩ������"));
        ts3.AddDialog(new DialogSplit("С��", "�ѵ����ƶ����������𡭡�",
           "С��", "�����Ҹ�����ʲô����"));
        dialogSequences.Add(ts3);

        //��
        DialogSequence ts4 = new DialogSequence(43, 46, GameState.LastSceneGame);
        ts4.AddDialog(new DialogSplit("С��", "��ͷ�۵����ˡ�",
           "С��", "�����Ժ��Ҿͱ��ˡ�"));
        ts4.AddDialog(new DialogSplit("С��", "ÿ�����дʵ�鱨�档",
            "С��", "���ս���ʶ��������һ�в���������Ūī��������Ϸ��"));
        ts4.AddDialog(new DialogSplit("С��", "д���衢��������ϴ��������",
           "С��", "��������ʲô������ı��ʲô���������ȵ�ʲô��"));
        ts4.AddDialog(new DialogSplit("С��", "���ȡ����衢���顢��ϡ���",
            "С��", "���Ҳ�֪��ʲô�ǰ�����û������ȥ�����Ҳ�֪�������Ƿ�ֵ�ñ�����"));
        ts4.AddDialog(new DialogSplit("С��", "̫�෱���Ƚ��ˡ�",
           "С��", "ֱ�����������㡣"));
        ts4.AddDialog(new DialogSplit("С��", "��Ȼ��ѧҲ��˫һ����������ϲ��������������",
           "С��", "����Զ���顢��ϡ����ᡣ��˭������������ʹ���Լ�����ѵ�ʱ����Ȼ��ֶԱ��˺á�"));
        ts4.AddDialog(new DialogSplit("С��", "���ѧԺ����ʦ�������о�ʲô����������ҩ�ɡ���",
           "С��", "��������Ŀ����ӽ�С��ʹ�Ĵ��ڡ�"));
        ts4.AddDialog(new DialogSplit("С��", "������ô����µĲ�����",
           "С��", "��Ϊ�㣬�Ҿ���������������Ҫ������ôһ�㡣"));
        ts4.AddDialog(new DialogSplit("С��", "�����������Ĺ��޻���ȥ����ʷ�ܰɡ�",
           "С��", "��Ը��������ø���ů��"));
        dialogSequences.Add(ts4);

        //��ʱ�նԻ�end
        DialogSequence ts5 = new DialogSequence(44, 46, GameState.LastSceneGame);
        ts5.AddDialog(new Dialog("С��", "��ȥ���ɣ�����Զ֧���㡣"));
        dialogSequences.Add(ts5);

        DialogSequence ts6 = new DialogSequence(45, 46, GameState.LastSceneGame);
        ts6.AddDialog(new DialogSplit("С��", "�ţ��һ����ᡣ",
            "С��", "�š���лл��֧���ҡ�"));
        ts6.AddDialog(new DialogSplit("С��", "���ξ�ȥ׷��",
           "С��", "лл�������¶����ġ�"));
        dialogSequences.Add(ts6);


        //�߳�
        DialogSequence e1 = new DialogSequence(46, 47, GameState.SceneGame);
        e1.AddDialog(new Dialog("С��", "����Ҳ��������Ǹ�ʱ�̣�������ʱ�޿������ﶼ���ظ���"));
        e1.AddDialog(new Dialog("С��", "������������ǰ��ȫ��Ұף��������¹���ҫ�»�Ҫ�׵Ĵ��ۡ�"));
        e1.AddDialog(new Dialog("С��", "�����ϲ����˹��ӣ������ܶ����п��ˡ��ҹ�������ǰ�����Ų���������������������"));
        e1.AddDialog(new Dialog("С��", "��ʲô�������ˡ�"));
        e1.AddDialog(new Dialog("С��", "��˯���š�"));
        e1.AddDialog(new Dialog("С��", "��ÿ�����϶�˯���š�"));
        e1.AddDialog(new Dialog("С��", "��һֱ����ج�Ρ�"));
        e1.AddDialog(new Dialog("С��", "�����޾���ج�Ρ�"));
        e1.AddDialog(new Dialog("С��", "��֪����˼����û���ã�����һֱ���롣"));
        e1.AddDialog(new Dialog("С��", "����ҵ���ѧ�˹���ҽѧ����ֹ�˷ǵ�ı�����"));
        e1.AddDialog(new Dialog("С��", "����ҵ�ʱ�����ú�ѧ��ѧ�����Ƴ��˲�������Чҩ��"));
        e1.AddDialog(new Dialog("С��", "�����û�г������������һ�����ܼ���������ѧ����š�"));
        e1.AddDialog(new Dialog("С��", "����Ҳ�������ʲô��ν���е����룬ʲô��ν���еĵ���׷��"));
        e1.AddDialog(new Dialog("С��", "����������Ҹ����������һ���������������ͼ��Ȱ����Ҫȥ��Σ�յ��¡�"));
        e1.AddDialog(new Dialog("С��", "����������һ��ȥ��"));
        e1.AddDialog(new Dialog("С��", "������ô��������������ʲô��û������ʲô�������ˡ�"));
        e1.AddDialog(new Dialog("С��", "�������ҵ���������ȴû�ܾ�������"));
        e1.AddDialog(new Dialog("С��", "����Ӧ�ü����ڴ�ѧУ԰�������������ü�����ѧ����·�ϴ�Ź�ʡ�"));
        e1.AddDialog(new Dialog("С��", "����������Ľ�������������"));
        e1.AddDialog(new Dialog("С��", "�����������ң�"));
        e1.AddDialog(new Dialog("С��", "���������������ҲŶԣ�"));
        e1.AddDialog(new Dialog("С��", "Ϊʲô��ʲô��û����Ϊʲô��ʲô�������ˡ�"));
        dialogSequences.Add(e1);

        DialogSequence e2 = new DialogSequence(47, 48, GameState.Dialog);
        e2.AddDialog(new Dialog("С��", "��Ҫ�˺��Լ�����"));
        e2.AddDialog(new Dialog("С��", "�����û���˺����ҡ�"));
        e2.AddDialog(new Dialog("С��", "��ʲô����Ƿ�ҡ�"));
        e2.AddDialog(new Dialog("С��", "һ�ж������Լ���ѡ��"));
        e2.AddDialog(new Dialog("С��", "���������ң������������������ơ��а���"));
        e2.AddDialog(new Dialog("С��", "�����Ҿ�������ֵ���ڴ�������ֵ�ñ�����"));
        e2.AddDialog(new Dialog("С��", "�ҲŻ���Ҫ�����ְ����ݳ�ȥ��"));
        e2.AddDialog(new Dialog("С��", "��û�д�������Ҳû�д��������д�"));
        e2.AddDialog(new Dialog("С��", "����"));
        e2.AddDialog(new Dialog("С��", "��Ӧ�����һ���������"));
        e2.AddDialog(new Dialog("С��", "�չ˺��Լ���"));
        dialogSequences.Add(e2);

        DialogSequence e3 = new DialogSequence(48, 49, GameState.Dialog);
        e3.AddDialog(new Dialog("С��", "����"));
        e3.AddDialog(new Dialog("С��", "��֪��Ϊʲô�һ���������ɡ�"));
        e3.AddDialog(new Dialog("С��", "��֪������ζ��ʲô�ɡ���"));
        e3.AddDialog(new Dialog("С��", "ˡ�Ҳ��ܴ�Ӧ���ˡ�"));
        e3.AddDialog(new Dialog("С��", "�Ҳ�������һ���˴������"));
        e3.AddDialog(new Dialog("С��", "���޷�����û�����������"));
        dialogSequences.Add(e3);

        DialogSequence e4 = new DialogSequence(49, 50, GameState.MiniGame);
        e4.AddDialog(new Dialog("С��", "����"));
        e4.AddDialog(new Dialog("С��", "�㻹�ǵ�����ҵġ��ż���Ҫ�����ҵ�������"));
        e4.AddDialog(new Dialog("С��", "����һ������ʷѧ�����塣"));
        e4.AddDialog(new Dialog("С��", "�Ҽǵá�"));
        e4.AddDialog(new Dialog("С��", "��ʷѧ�����壬����˵��Ϊ�����ṩ��Ϊָ�ϣ�����˵��Ϊ�˴����Լ���˼�����ţ�������˵����Ϊ���ֲ�ʧ�䡭��"));
        e4.AddDialog(new Dialog("С��", "�Ҽǵ���������û�д�ɹ�ʶ������һ�����Ƕ��Ͽɡ�"));
        e4.AddDialog(new Dialog("С��", "��ʷ�Ľ�������������������ѵĴ��ݡ�"));
        e4.AddDialog(new Dialog("С��", "����"));
        dialogSequences.Add(e4);


        DialogSequence e5 = new DialogSequence(50, 51, GameState.MiniGame);
        e5.AddDialog(new Dialog("С��", "���������Ϊ�����߶������ˣ���ô���������������߿�˭ȥָ������˭ȥ��ů�أ�"));
        e5.AddDialog(new Dialog("С��", "��Ҫ����ȥ�������ǵĹ��¡�"));
        e5.AddDialog(new Dialog("С��", "�������԰����ǳԹ��Ŀ���ҩ�裬ιͬ���������˳���ȥ���������뿪���ס�"));
        e5.AddDialog(new Dialog("С��", "���񵱳����ǻ������������"));
        e5.AddDialog(new Dialog("С��", "�������λ������"));

        e5.AddDialog(new Dialog("С��", "����"));
        e5.AddDialog(new Dialog("С��", "û�뵽���һ�Σ�����������ҡ���"));
        e5.AddDialog(new Dialog("С��", "�Բ��𡭡�"));

        e5.AddDialog(new Dialog("С��", "����ô˵"));
        e5.AddDialog(new Dialog("С��", "�Ҽ���̫������û���ź��ˡ�"));

        e5.AddDialog(new Dialog("С��", "����̫���������ǵģ�����Ҫ˯�ˡ���"));
        e5.AddDialog(new Dialog("С��", "һֱ�߰ɣ��߳����ӵ�����⡣Ȼ���Ϊ̫����"));
        e5.AddDialog(new Dialog("С��", "�����ҵ��Ƿ�һ��"));

        e5.AddDialog(new Dialog("С��", "�ٸ���һ��ʱ�䣬��һ�����"));
        e5.AddDialog(new Dialog("С��", "�����Ұɣ����һ�Ρ�"));
        e5.AddDialog(new Dialog("С��", "�ҿ����ˡ���"));
        dialogSequences.Add(e5);


        //β��

        DialogSequence e6 = new DialogSequence(51, 52, GameState.SceneGame);
        e6.AddDialog(new Dialog("С��", "�������һ���û��������ѧ����ͷ�����ò��ҷݹ��������öȡ�"));
        e6.AddDialog(new Dialog("С��", "����Ȼ�������Ĺػ������������е��������ϸ�����ߵ�ÿһ���ˡ�"));
        e6.AddDialog(new Dialog("С��", "С�ո����һ���ȥ�����ɣ����ս��¸ҵ�ѧ�������һ�С�"));
        e6.AddDialog(new Dialog("С��", "�Ұ������ġ����������ߡ��ܶ࣬Ҳ��ֻ��һЩ������������е��ˡ�"));
        e6.AddDialog(new Dialog("С��", "�����������Ҳ���ǣ���û��Ȧ������Լ�Ҽ���������ģ�Ҳ���˾�������"));
        e6.AddDialog(new Dialog("С��", "ʦ�����á�������С����"));
        dialogSequences.Add(e6);

        DialogSequence e7 = new DialogSequence(52, 53, GameState.MiniGame);
        e7.AddDialog(new Dialog("С��", "֮ǰ��ѯ����ѧ��Ȧ�����飬����������л�ġ�"));
        e7.AddDialog(new Dialog("С��", "���Ѿ��Ե�һ���ĳɼ���ѡ�ˣ������ƾ衭��"));
        e7.AddDialog(new Dialog("С��", "��ϲ��������Ǹ�Ҽǲ����ˣ���֮ǰ������Ͷ���"));
        e7.AddDialog(new Dialog("С��", "��֮ǰ����ʷѧϵ��"));
        e7.AddDialog(new Dialog("С��", "���������ˣ���Ҳ����ʷѧϵ��һ����"));
        e7.AddDialog(new Dialog("С��", "����������о������ˣ�"));
        e7.AddDialog(new Dialog("С��", "�Եġ�"));
        e7.AddDialog(new Dialog("С��", "ʦ������ʱȰ���ҡ�����˵�˺ܶ࡭��"));
        dialogSequences.Add(e7);

        DialogSequence e8 = new DialogSequence(53, 54, GameState.Dialog);
        e8.AddDialog(new Dialog("С��", "����ĺܸж���"));
        e8.AddDialog(new Dialog("С��", "��֪��˵�滰���д��۵ģ���û�뵽�������˵��ô�ࡣ"));
        e8.AddDialog(new Dialog("С��", "��֪�����ܶ����õĶ������Ǽٵġ�"));
        e8.AddDialog(new Dialog("С��", "�������ݣ�����Ѥ�ã���ʵһ����һ�ֵ���ʪ��"));
        e8.AddDialog(new Dialog("С��", "��֪�����������й��ղ����ĵط���"));
        e8.AddDialog(new Dialog("С��", "����������ѧ�Ƶ�ʹ�������������������"));
        e8.AddDialog(new Dialog("С��", "��Ը�⾡��������ů������硣"));
        e8.AddDialog(new Dialog("С��", "�����о����࣬�����Ǹ��ߵĵ��ã�������������¡�"));
        dialogSequences.Add(e8);

        DialogSequence e9 = new DialogSequence(54, 55, GameState.Dialog);
        e9.AddDialog(new Dialog("С��", "����"));
        e9.AddDialog(new Dialog("С��", "���������ô��ģ�"));
        e9.AddDialog(new Dialog("С��", "�Ҿ�����˵�Ĺ��п��ˡ�"));
        e9.AddDialog(new Dialog("С��", "���ľ����ǿɹ�ģ���Ȧ�Ӳ�һ����"));
        e9.AddDialog(new Dialog("С��", "�����о����������ǰ̤����Ȧ�ӡ�"));
        e9.AddDialog(new Dialog("С��", "Ȧ����Ķ�����Ǳ������ˮ��ɲ����鱾�ϵĶ���һ�������ɼ���"));
        e9.AddDialog(new Dialog("С��", "���������������������黳����ţ���Ȧ�ӵĲ���������"));
        e9.AddDialog(new Dialog("С��", "Ҫô���ڳ����ɣ���Ϊ�ڰ���һ���֡�"));
        e9.AddDialog(new Dialog("С��", "Ҫô����ĥ�ı������˳��ߣ�Ϊ�������һ�С�"));
        e9.AddDialog(new Dialog("С��", "����������Ҫ�������۵ġ�"));
        e9.AddDialog(new Dialog("С��", "������Ȧ����첻���������Լ�����һ�����С�"));
        e9.AddDialog(new Dialog("С��", "�������ˣ������������ˣ���������Ǻõö��ѡ��"));
        dialogSequences.Add(e9);

        DialogSequence e10 = new DialogSequence(55, 56, GameState.SceneGame);
        e10.AddDialog(new Dialog("С��", "лл��ʦ�֣��������������ԡ�"));
        e10.AddDialog(new Dialog("С��", "�˺���û�о���ұ���Ψһ�Ĺ⡣"));
        e10.AddDialog(new Dialog("С��", "����"));
        e10.AddDialog(new Dialog("С��", "���Ͱɣ�ף��˷����ˡ�"));
        e10.AddDialog(new Dialog("С��", "ллʦ�֡���һ���ú�Ŭ����δ���ټ���"));
        e10.AddDialog(new Dialog("С��", "�ȵȡ���"));
        e10.AddDialog(new Dialog("С��", "����"));
        e10.AddDialog(new Dialog("С��", "�ǵã��չ˺��Լ���"));
        e10.AddDialog(new Dialog("С��", "���С���"));
        e10.AddDialog(new Dialog("С��", "������ԵĻ���Ŭ����̫���ɡ�"));
        dialogSequences.Add(e10);
    }
}
