function solution() {
    class Post {
        constructor(title, content) {
            this.title = title;
            this.content = content;
        }
        toString(){
            return `Post: ${this.title}\nContent: ${this.content}`;
        }
    }
    class SocialMediaPost extends Post {
        constructor(title, content, likes, dislikes) {
            super(title, content);
            this.likes = likes;
            this.dislikes = dislikes;
            this.comments = [];
        }
        addComment = (text) => {
            this.comments.push(text);
        }
        toString = () => {
            let result = super.toString() + `\n`;
            result += `Rating: ${this.likes - this.dislikes}\n`;
            if (this.comments.length > 0) {
                result += "Comments:\n"
                this.comments.forEach(x => {
                    result += ` * ${x}\n`
                })
            }  
            return result.trim();
        }
    }
    class BlogPost extends Post{
        constructor(title, content, views) {
            super(title, content);
            this.views = views;
        }
        view=()=>{
            this.views++;
            return this;
        }
        toString=()=>{
            let result = super.toString() + `\n`;
            result += `Views: ${this.views}`;
            return result;
        }
    }
    return{Post,SocialMediaPost,BlogPost}
}

const classes = solution();
let post = new classes.Post("Post", "Content");

console.log(post.toString());

// Post: Post
// Content: Content

let scm = new classes.SocialMediaPost("TestTitle", "TestContent", 25, 30);

scm.addComment("Good post");
scm.addComment("Very good post");
scm.addComment("Wow!");

console.log(scm.toString());

// Post: TestTitle
// Content: TestContent
// Rating: -5
// Comments:
//  * Good post
//  * Very good post
//  * Wow!
