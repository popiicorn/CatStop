using UnityEngine;
using GoogleMobileAds.Api;
using System;


public class AdMobReward : MonoBehaviour
{
    //��邱��
    //1.�����[�h�L��ID�̓���
    //2.Update�֐���if�����ɕ�V���e�����
    //3.�����[�h�N���ݒ�@ShowAdMobReward()���g��

    public ClearPoint clearPoint;
    public GameObject rewordButton;


    private bool rewardeFlag = false;//�����[�h�L���̕�V�t�^�p�@�����l��false

    private RewardedAd rewardedAd;//RewardedAd�^�̕ϐ� rewardedAd��錾 ���̒��Ƀ����[�h�L���̏�񂪓���

    private string adUnitId;

    //�����[�h�L����\������֐�
    //�{�^���Ɋ��t�����Ďg�p
    public void ShowAdMobReward()
    {
        //�L���̓ǂݍ��݂��������Ă�����L���\��
        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
            Debug.Log("�����[�h�L���\��");
        }
        else
        {
            Debug.Log("�����[�h�L���ǂݍ��ݖ�����");
        }
    }


    private void Update()
    {
        //�L�����������rewardeFlag��true�ɂ��Ă���
        //�L���������炱�̒��̏��������s�����
        if (rewardeFlag == true)
        {
            rewardeFlag = false;//��V�t�^�p�̃t���O��false�֖߂�

            //�����ɕ�V�̏���������
            int score = 5 + clearPoint.clearpoint;
            clearPoint.textClearPoint.text = score + "";

            //�|�C���g�l�̃Z�[�u
            ES3.Save<int>("Clearkey", score);

            rewordButton.SetActive(false);
        }

    }


    private void Start()
    {
        //Android��iOS�ōL��ID���Ⴄ�̂Ńv���b�g�t�H�[���ŏ����𕪂��܂��B
        // �Q�l
        //�yUnity�zAndroid��iOS�ŏ����𕪂�����@
        // https://marumaro7.hatenablog.com/entry/platformsyoriwakeru

#if UNITY_ANDROID
        adUnitId = "ca-app-pub-6736870106967218/7998508352";//������Android�̃����[�h�L��ID�����
#elif UNITY_IPHONE
        adUnitId = "ca-app-pub-6736870106967218/6905667933";//������iOS�̃����[�h�L��ID�����
#else
        adUnitId = "unexpected_platform";
#endif

        CreateAndLoadRewardedAd();//�����[�h�L���ǂݍ���
    }

    //�����[�h�L���ǂݍ��ފ֐�
    public void CreateAndLoadRewardedAd()
    {
        //�����[�h�L��������
        rewardedAd = new RewardedAd(adUnitId);

        //RewardedAd�^�̕ϐ� rewardedAd�̊e���� �Ɋ֐���o�^
        rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;//rewardedAd�̏�Ԃ� �����[�h�L���ǂݍ��݊��� �ƂȂ������ɋN������֐�(�֐���HandleRewardedAdLoaded)��o�^
        rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;//rewardedAd�̏�Ԃ��@�����[�h�L���ǂݍ��ݎ��s �@�ƂȂ������ɋN������֐�(�֐���HandleRewardedAdFailedToLoad)��o�^
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;//rewardedAd�̏�Ԃ�  �����[�h�L������ꂽ�@�ƂȂ������ɋN������֐�(�֐���HandleRewardedAdFailedToLoad)��o�^
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;//rewardedAd�̏�Ԃ� ���[�U�[�̕�V�����@�ƂȂ������ɋN������֐�(�֐���HandleUserEarnedReward)��o�^


        //���N�G�X�g�𐶐�
        AdRequest request = new AdRequest.Builder().Build();
        //���N�G�X�g�Ƌ��Ƀ����[�h�L�������[�h
        rewardedAd.LoadAd(request);
    }


    //�����[�h�ǂݍ��݊��� �ƂȂ������ɋN������֐�
    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        Debug.Log("�����[�h�L���ǂݍ��݊���");
    }

    //�����[�h�ǂݍ��ݎ��s �ƂȂ������ɋN������֐�
    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        Debug.Log("�����[�h�L���ǂݍ��ݎ��s" + args.LoadAdError);//args.LoadAdError:�G���[���e 
    }

    //�����[�h�L������ꂽ���ɋN������֐�
    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        Debug.Log("�����[�h�L��������");

        //�L���ēǂݍ���
        CreateAndLoadRewardedAd();
    }

    //���[�U�[�̕�V���� �ƂȂ������ɋN������֐�
    public void HandleUserEarnedReward(object sender, Reward args)
    {
        Debug.Log("��V�󂯎��");

        //���̊֐����ł̓Q�[���I�u�W�F�N�g�̑��삪�ł��Ȃ�
        //���̂��߁A�����ł͕�V�󂯎��̃t���O��true�ɂ��邾���ɂ���
        //��̓I�ȏ�����Update�֐����ōs���B
        rewardeFlag = true;
    }


}