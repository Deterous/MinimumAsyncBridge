# MinimumAsyncBridge

async/await �̎��s�ɕK�v�ȍŒ���̎����B

C# 5.0 �� async/await �� .NET 3.5/Unity �Q�[�� �G���W����Ŏ��s�ł���悤�ɂ��邽�߂̃��C�u�����B

## �w�i

### C# 5.0 async/await

C# 5.0 �� async/await �̎��s�ɂ́A

- .NET 4 �Œǉ����ꂽ 'Task' �N���X
- .NET 4.5 �Œǉ����ꂽ `AsyncTaskMethodBuilder` �Ȃǂ̈�A�̃N���X

���K�v�B

�������o�b�N�|�[�e�B���O����΁A.NET 3.5 ��ł� C# 5.0 ���g����B

### Unity �̐���

�����AUnity �͗��p���Ă��� .NET �����^�C�����Â���(Mono 2.8�n)�A���낢�됧��������B

���ɁAiOS �͉��z�}�V�����s���ł��Ȃ��̂� AOT (Ahead of Time)�R���p�C�����s���Ă��āA����̐��������Ɍ������B

2015�N���݁AUnity �� iOS ��ł̎��s�� Mono �� AOT �R���p�C������A�Ǝ������� [IL2CPP](http://blogs.unity3d.com/2014/05/20/the-future-of-scripting-in-unity/)�Ƃ��������Ɉڍs���Ȃ��̂́A
������܂��܂��s����B

���ʂƂ��āA�t���@�\�� `Task` �̈ڐA�� Unity ��(���� iOS)�œ������Ȃ��\���������B

���ہA�L���ǂ���� `Task` �o�b�N�|�[�e�B���O��������Unity��Ŏg���Ă݂��Ƃ���A����ł�IL2CPP�̃R���p�C���Ɏ��s(2015/7���_)�B

- [AsyncBridge](http://omermor.github.io/AsyncBridge/)

#### �����I��

IL2CPP �͏��X�ɉ��P���Ă����Ă���̂ŁA��L�����͏��X�ɂȂ��Ȃ�͂��B

�����AIL2CPP �̓R���p�C���ɔ��Ɏ��Ԃ�������̂ŁA���@�m�F�̂��т� IL2CPP �ŃR���p�C������̂̓X�g���X���������B

�Ȃ̂ŁA���ʂ̊Ԃ� Mono AOT �ł��������C�u�������K�v�B
���A�����������珫���I�ɂ͕W�����C�u�����Ɉڍs�ł���\�����l�����������K�v�B

## ���̃��|�W�g�����񋟂������

async/await ���g�����������Ȃ�A�t���@�\�� `Task` �N���X�͗v��Ȃ��B
�K�v�Ȃ̂� `TaskCompletionSource<TResult>` �N���X(C++ �� `std::promise` �I�Ȃ���)�����Ȃ̂ŁA����������������΂����B

���������ł���΁AMono AOT �� IL2CPP �̐����Ɉ��������邱�ƂȂ������ł����B

�c��́A��ʓI�� `Task` �N���X�̍��A���Ȃ킿�A�}���`�X���b�h���s(`Task.Run`)��^�C�}�[(`Task.Delay`)�͎������Ă��Ȃ��B
���̕ӂ�́A���̔񓯊��������C�u�����ƂȂ�����Ŗ��߂�z��B

��̓I�ɂ́A���̃��|�W�g���ɂ́A

- �W���� `Task` �̉��ʌ݊�����
  - `System.Threading.Tasks` ���O��Ԃɒ�`
  - `TaskCompletionSource<TResult>` �Ɋ֘A���镔������������
    - `Task.Run`��`Task.Delay`�Ȃǂ̃��\�b�h�͂Ȃ��B
  - .NET 4.5�ȏ�Ŏ��s����p�ɁA�W�����C�u�����ւ̌^�t�H���[�f�B���O����
- `AsyncTaskMethodBuilder` �̃o�b�N�|�[�e�B���O
  - [�}�C�N���\�t�g�̎Q�ƃ\�[�X�R�[�h](http://referencesource.microsoft.com/)���x�[�X
- [UniRx](https://github.com/neuecc/UniRx)��[IteratorTasks](https://github.com/OrangeCube/IteratorTasks)�ɑ΂��� awaiter ����

���܂܂�Ă���B

## �o�C�i����

NuGet �p�b�P�[�W���ς�:

- [MinimumAsyncBridge](https://www.nuget.org/packages/MinimumAsyncBridge/): async/await �̎��s�ɕK�v�ȍŒ���̎���
  - .NET 4.5 ����p�b�P�[�W�Q�Ƃ���ƁA�W�����C�u�����ւ̌^�t�H���[�f�B���O
- [IteratorTasks.AsyncBridge](https://www.nuget.org/packages/IteratorTasks.AsyncBridge/): [IteratorTasks](https://www.nuget.org/packages/IteratorTasks/)�ɑ΂��� awaiter ����

(�� [UniRx](https://github.com/neuecc/UniRx)�͖{�̂� NuGet �p�b�P�[�W�ɂȂ��Ă��Ȃ��̂� awaiter �����̃p�b�P�[�W���J�Ȃ�)

