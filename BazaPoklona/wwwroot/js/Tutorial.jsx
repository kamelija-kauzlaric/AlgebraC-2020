const data = [
    { id: 1, author: 'Daniel Lo Nigro', text: 'Hello ReactJS.NET World!' },
    { id: 2, author: 'Pete Hunt', text: 'This is one comment' },
    { id: 3, author: 'Jordan Walke', text: 'This is *another* comment' },
];

function createRemarkable() {
    var remarkable =
        'undefined' != typeof global && global.Remarkable
            ? global.Remarkable
            : window.Remarkable;

    return new remarkable();
}

class Comment extends React.Component {
    rawMarkup() {
        const md = new Remarkable();
        const rawMarkup = md.render(this.props.children.toString());
        return { __html: rawMarkup };
    }
    render() {
        const md = createRemarkable();
        return (
            <div className="comment">
                <h2 className="commentAuthor">{this.props.author} ({this.props.key})</h2>
                <span dangerouslySetInnerHTML={this.rawMarkup()} />
            </div>
        );
    }
}

// NOVI - REPEATER (sa .map())

class CommentList extends React.Component {
    render() {
        const commentNodes = this.props.data.map(comment => (
            <Comment author={comment.author} key={comment.id}>
                {comment.text}
            </Comment>
        ));
        return <div className="commentList">{commentNodes}</div>;
    }
}

// STARI:

//class CommentList extends React.Component {
//    render() {
//        return (
//            <div className="commentList">



//                <Comment author="Daniel Lo Nigro" age="99">
//                    Hello ReactJS.NET World!
//                </Comment>

//                <Comment author="Pete Hunt" age="78"> This is one comment</Comment >

//                <Comment author="Jordan Walke" age="44">
//                    This is *another* comment.
//                    - list
//                    - list2
//                    -neka jos lista
//                    # h1
//                    # h2
//                    # h3
//                    __boldano__
//                </Comment >

//            </div >
//        );
//    }
//}

class CommentForm extends React.Component {
    render() {
        return (
            <div className="commentForm">Hello, world! I am a CommentForm.</div>
        );
    }
}

// KLASA - ime klase - koga naslijeđuje - metoda render
// Dovoljno ubaciti klase kao tagove, a gore smo definirali što oni ispisuju.

class CommentBox extends React.Component {
    constructor(props) {
        super(props);
        this.state = { data: [] };
    }
    render() {
        return (
            <div className="commentBox">
                <h1>Comments</h1>
                <CommentList data={this.state.data} />
                <CommentForm />
            </div>
        );
    }
}

//class CommentBox extends React.Component {
//    render() {
//        return (
//            <div className="commentBox">

//                <h1>Comments</h1>

//                <CommentList data={this.props.data} />
//                <CommentForm />
//            </div>
//        );
//    }
//}

// NAREDBA - renderiraj mi (ispiši) ovaj CommentBox element prema klasi CommentBox
// Postavi to na ovaj zadnji tag 'content' - id diva di će se ispisat (može tu i span, šta god...).

ReactDOM.render(
    <CommentBox url="/comments" />,
    document.getElementById('content')
);

// STARO ali sa nekim parametrima
// ReactDOM.render(<CommentBox data={data} />, document.getElementById('content'));

// STARO sa hard-coded podacima:
// ReactDOM.render(<CommentBox />, document.getElementById('content'));