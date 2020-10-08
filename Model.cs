using System;

namespace Model
{
    public class UserInfo
    {
        public string userName { get; set; }
        public string passWord { get; set; }
        public string qq { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public string userImg { get; set; }
    }
    public class UserInfoNo : UserInfo
    {
        public int num { get; set; }
    }
    public class Page
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
    public class Activity
    {
        public int activityId { get; set; }
        public string activityName { get; set; }
        public DateTime endTime { get; set; }
        public string ActivityPicture { get; set; }
        public string ActivityIntroduction { get; set; }
        public string Summary { get; set; }
        public string ActivityVerify { get; set; }
        public string ActivityStatus { get; set; }
        public string UserName { get; set; }
        public string Recommend { get; set; }
        public DateTime RecommendTime { get; set; }

        public class WorkInfo
        {
            public int workId { get; set; }
            public string WorkName { get; set; }
            public string WorkPicture { get; set; }
            public DateTime UploadTime { get; set; }
            public string WorkIntroduction { get; set; }
            public string WorkVerify { get; set; }
            public string UserName { get; set; }
            public int ActivityId { get; set; }
            public string Recommend { get; set; }
            public DateTime RecommendTime { get; set; }

        }
        public class Comment
        {
            public int commentId { get; set; }
            public int WorkId { get; set; }
            public string UserName { get; set; }
            public string CommentContent { get; set; }
            public DateTime CommentTime { get; set; }
        }
        public class WorkFindPage : Page
        {
            public string workName { get; set; }
        }
        public class WorkMyPage : Page
        {
            public string userName { get; set; }
        }
        public class CommentPage : Page
        {
            public string workId { get; set; }
        }
        public class ActivityNo : Activity
        {
            public int num { get; set; }
        }
        public class ActivityName
        {
            public int activityId { get; set; }
            public string activityName { get; set; }
        }
        public class WorkInfoNo : WorkInfo
        {
            public int num { get; set; }
            public string activityName { get; set; }
        }
        public class CommentNo : Comment
        {
            public int num { get; set; }
            public string workName { get; set; }
        }
    }
}
